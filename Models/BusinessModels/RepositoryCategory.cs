using BTLASPMONGO.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Text.RegularExpressions;

namespace BTLASPMONGO.Models.BusinessModels
{
    public class RepositoryCategory : IRepositoryCategory
    {
        NewsDbContext _context;
        public RepositoryCategory(NewsDbContext _context)
        {
            this._context = _context;
        }

        public bool CheckName(string name)
        {
            var category = _context.Categories.Find(x => x.category_name.ToLower() == name.ToLower().Trim()).FirstOrDefault();
            if (category != null)
            {
                return true;
            }
            return false;
        }

        public bool Delete(string key)
        {
            _context.Categories.DeleteOne(x => x._id.Equals(key));
            return true;
        }

        public List<Category> GetAll()
        {
            return _context.Categories.Find(FilterDefinition<Category>.Empty).ToList();
        }

        public Category GetById(string key)
        {
            return _context.Categories.Find(x => x._id.Equals(key)).FirstOrDefault();
        }

        public List<Category> GetByStatus()
        {
           return _context.Categories.Find(x => x.status == true).ToList();
        }

        public bool Insert(Category entity)
        {
            _context.Categories.InsertOne(entity);
            return true;
        }

        public List<Category> Pageing(int page, int page_size, string name, string sort, out long total_Page)
        {
            int skip = page_size * (page - 1);
            var test = _context.Categories.AsQueryable();
            var total_document = _context.Categories.CountDocuments(FilterDefinition<Category>.Empty);

            if (!string.IsNullOrEmpty(name))
            {
                total_document = _context.Categories.CountDocuments(x => x.category_name.ToLower().Contains(name.ToLower()));
            }
            total_Page = total_document % page_size == 0 ? total_document / page_size : total_document / page_size + 1;

           

            var data = _context.Categories.Find(FilterDefinition<Category>.Empty).SortByDescending(x => x.creation_time).Skip(skip).Limit(page_size).ToList();

            if (sort == "ASC")
            {
                data = _context.Categories.Find(FilterDefinition<Category>.Empty).SortBy(x => x.category_name).Skip(skip).Limit(page_size).ToList();
            }
            if (sort == "DESC")
            {
                data = _context.Categories.Find(FilterDefinition<Category>.Empty).SortByDescending(x => x.category_name).Skip(skip).Limit(page_size).ToList();
            }


            if (!string.IsNullOrEmpty(name))
            {
                data = _context.Categories.Find(x=>x.category_name.ToLower().Contains(name.ToLower())).SortByDescending(x => x.creation_time).Skip(skip).Limit(page_size).ToList();
            }
            else if (!string.IsNullOrEmpty(name) && sort == "ASC")
            {
                data = _context.Categories.Find(x => x.category_name.ToLower().Contains(name.ToLower())).SortBy(x => x.category_name).Skip(skip).Limit(page_size).ToList();
            }
            else if (!string.IsNullOrEmpty(name) && sort == "DESC")
            {
                data = _context.Categories.Find(x => x.category_name.ToLower().Contains(name.ToLower())).SortByDescending(x => x.category_name).Skip(skip).Limit(page_size).ToList();
            }
            return data;
        }



        public bool Update(Category entity)
        {
            var category = Builders<Category>.Update.Set("category_name", entity.category_name)
                .Set("status", entity.status)
                .Set("creation_time", entity.creation_time);
            _context.Categories.UpdateOne(x => x._id == entity._id, category);
            return true;
        }
    }
}
