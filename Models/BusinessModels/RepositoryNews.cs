using BTLASPMONGO.Models.DataModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Text.RegularExpressions;
using BTLASPMONGO.ViewModel;

namespace BTLASPMONGO.Models.BusinessModels
{
    public class RepositoryNews : IRepositoryNews
    {
        NewsDbContext _context;

        public RepositoryNews(NewsDbContext _context)
        {
            this._context = _context;
        }
        public bool Delete(string key)
        {
            _context.News.DeleteOne(x => x._id == key);
            return true;
        }

        public List<NewsViewModel> GetAllNewsModel()
        {
            var data = _context.News.Aggregate().Match(x => x.status == 3)
                                                .SortByDescending(x => x.published_time)
                                                .Lookup("Categories", "news_category", "_id", "categoriy")
                                                .ToList();
            var data_view = new List<NewsViewModel>();
            foreach (var item in data)
            {
                var news = new NewsViewModel();
                news._id = item["_id"].ToString();
                news.news_title = item["news_title"].ToString();
                news.news_excerpt = item["news_excerpt"].ToString();
                news.categoryId = item["categoriy"].AsBsonArray[0]["_id"].ToString();
                news.news_category = item["categoriy"].AsBsonArray[0]["category_name"].ToString();
                news.picture = item["picture"].ToString();
                if (item["published_time"].ToString() != "BsonNull")
                {
                    news.published_time = DateTime.Parse(item["published_time"].ToString());
                }
                news.total_views = Int32.Parse(item["total_views"].ToString());
                data_view.Add(news);
            }
            return data_view;
        }


        public List<News> GetAll()
        {
            var data = _context.News.Aggregate().Match(x => x.status == 3)
                                                .SortByDescending(x => x.published_time)
                                                .Lookup("Categories", "news_category", "_id", "categoriy")
                                                .ToList();
            var data_view = new List<News>();
            foreach (var item in data)
            {
                var news = new News();
                news._id = item["_id"].ToString();
                news.news_title = item["news_title"].ToString();
                news.news_excerpt = item["news_excerpt"].ToString();
                news.news_category = item["categoriy"].AsBsonArray[0]["category_name"].ToString();
                news.picture = item["picture"].ToString();
                if (item["published_time"].ToString() != "BsonNull")
                {
                    news.published_time = DateTime.Parse(item["published_time"].ToString());
                }
                news.total_views = Int32.Parse(item["total_views"].ToString());
                data_view.Add(news);
            }
            return data_view;
        }

        public News GetById(string key)
        {
            var data = _context.News.Aggregate().Match(p => p._id == key)
                                                .Lookup("Categories", "news_category", "_id", "categoriy")
                                                .Lookup("Account", "user_id", "_id", "account").FirstOrDefault();

            var news = new News();
            news._id = data["_id"].ToString();
            news.news_title = data["news_title"].ToString();
            news.news_excerpt = data["news_excerpt"].ToString();
            news.news_content = data["news_content"].ToString();
            news.news_category = data["categoriy"].AsBsonArray[0]["category_name"].ToString();
            news.user_id = data["account"].AsBsonArray[0]["fullname"].ToString();
            news.status = Int32.Parse(data["status"].ToString());
            news.picture = data["picture"].ToString();
            news.creation_time = DateTime.Parse(data["creation_time"].ToString());
            news.last_modification_time = DateTime.Parse(data["last_modification_time"].ToString());
            if (data["published_time"].ToString() != "BsonNull")
            {
                news.published_time = DateTime.Parse(data["published_time"].ToString());
            }
            news.total_views = Int32.Parse(data["total_views"].ToString());

            return news;
        }

        public bool Insert(News entity)
        {
            _context.News.InsertOne(entity);
            return true;
        }


        public List<News> Get_All_News(int page, int page_size, string name, string sort_Order, string sort_Order_By, out long total_Page)
        {
            int skip = page_size * (page - 1);
            var total_document = _context.News.CountDocuments(FilterDefinition<News>.Empty);

            if (!string.IsNullOrEmpty(name))
            {
                total_document = _context.News.CountDocuments(x => x.news_title.ToLower().Contains(name.ToLower()));
            }
            total_Page = total_document % page_size == 0 ? total_document / page_size : total_document / page_size + 1;


            var data = _context.News.Find(FilterDefinition<News>.Empty).SortByDescending(x => x.creation_time).Skip(skip).Limit(page_size).ToList();

            if (!string.IsNullOrEmpty(name))
            {
                if (sort_Order_By != "")
                {
                    switch (sort_Order_By)
                    {
                        case "news_title":
                            if (sort_Order == "ASC")
                            {
                                data = _context.News.Find(x => x.news_title.ToLower().Contains(name.ToLower())).SortBy(x => x.news_title).Skip(skip).Limit(page_size).ToList();
                            }
                            else
                            {
                                data = _context.News.Find(x => x.news_title.ToLower().Contains(name.ToLower())).SortByDescending(x => x.news_title).Skip(skip).Limit(page_size).ToList();
                            }
                            break;
                        case "published_time":
                            if (sort_Order == "ASC")
                            {
                                data = _context.News.Find(x => x.news_title.ToLower().Contains(name.ToLower())).SortBy(x => x.published_time).Skip(skip).Limit(page_size).ToList();
                            }
                            else
                            {
                                data = _context.News.Find(x => x.news_title.ToLower().Contains(name.ToLower())).SortByDescending(x => x.published_time).Skip(skip).Limit(page_size).ToList();
                            }
                            break;
                        case "total_views":
                            if (sort_Order == "ASC")
                            {
                                data = _context.News.Find(x => x.news_title.ToLower().Contains(name.ToLower())).SortBy(x => x.total_views).Skip(skip).Limit(page_size).ToList();
                            }
                            else
                            {
                                data = _context.News.Find(x => x.news_title.ToLower().Contains(name.ToLower())).SortByDescending(x => x.total_views).Skip(skip).Limit(page_size).ToList();
                            }
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    data = _context.News.Find(x => x.news_title.ToLower().Contains(name.ToLower())).SortByDescending(x => x.creation_time).Skip(skip).Limit(page_size).ToList();
                }
            }
            else
            {
                if (sort_Order_By != "")
                {
                    switch (sort_Order_By)
                    {
                        case "news_title":
                            if (sort_Order == "ASC")
                            {
                                data = _context.News.Find(FilterDefinition<News>.Empty).SortBy(x => x.news_title).Skip(skip).Limit(page_size).ToList();
                            }
                            else
                            {
                                data = _context.News.Find(FilterDefinition<News>.Empty).SortByDescending(x => x.news_title).Skip(skip).Limit(page_size).ToList();
                            }
                            break;
                        case "published_time":
                            if (sort_Order == "ASC")
                            {
                                data = _context.News.Find(FilterDefinition<News>.Empty).SortBy(x => x.published_time).Skip(skip).Limit(page_size).ToList();
                            }
                            else
                            {
                                data = _context.News.Find(FilterDefinition<News>.Empty).SortByDescending(x => x.published_time).Skip(skip).Limit(page_size).ToList();
                            }
                            break;
                        case "total_views":
                            if (sort_Order == "ASC")
                            {
                                data = _context.News.Find(FilterDefinition<News>.Empty).SortBy(x => x.total_views).Skip(skip).Limit(page_size).ToList();
                            }
                            else
                            {
                                data = _context.News.Find(FilterDefinition<News>.Empty).SortByDescending(x => x.total_views).Skip(skip).Limit(page_size).ToList();
                            }

                            break;
                        default:
                            break;
                    }
                }
            }

            return data;
        }


        public bool Update(News entity)
        {
            var news = Builders<News>.Update.Set("news_title", entity.news_title)
                .Set("news_excerpt", entity.news_excerpt)
                .Set("news_content", entity.news_content)
                .Set("picture", entity.picture)
                .Set("news_category", entity.news_category)
                .Set("published_time", entity.published_time)
                .Set("last_modification_time", entity.last_modification_time)
                .Set("status", entity.status)
                .Set("total_views", entity.total_views);
            _context.News.UpdateOne(x => x._id == entity._id, news);
            return true;
        }

        public string UploadFile(IFormFile image)
        {
            string urlImg = "";
            if (image != null && image.Length > 0)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Admin/UpLoadImage/News/" + image.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    image.CopyTo(stream);
                }
                urlImg = "Admin/UpLoadImage/News/" + image.FileName;
            }
            return urlImg;
        }

        public List<News> Get_News_By_Category(string id)
        {
            return _context.News.Find(x => x.news_category == id && x.status == 3).SortByDescending(x => x.published_time).Limit(8).ToList();
        }

        public News GetByIdToChange(string key)
        {
            return _context.News.Find(x => x._id == key).FirstOrDefault();
        }

        public List<NewsViewModel> NewsSearch(string key, string date, string category)
        {


            var data = _context.News.Aggregate().Match(x => x.status == 3 && x.news_title.ToLower().Contains(key.ToLower()))
                                                .SortByDescending(x => x.published_time)
                                                .Lookup("Categories", "news_category", "_id", "categoriy")
                                                .ToList();
            var filterBuilder = Builders<News>.Filter;
            if (category != "all" && category != null)
            {
                data = _context.News.Aggregate().Match(x => x.status == 3 && x.news_title.ToLower().Contains(key.ToLower()))
                                                  .Match(x => x.news_category == category)
                                                  .SortByDescending(x => x.published_time)
                                                  .Lookup("Categories", "news_category", "_id", "categoriy")
                                                  .ToList();
                if (date == "day")
                {
                    var filter = filterBuilder.Gte(x => x.published_time, DateTime.UtcNow.AddDays(-1).Date);
                    data = _context.News.Aggregate().Match(x => x.status == 3 && x.news_title.ToLower().Contains(key.ToLower()))
                                                    .Match(x => x.news_category == category)
                                                    .Match(filter)
                                                    .SortByDescending(x => x.published_time)
                                                    .Lookup("Categories", "news_category", "_id", "categoriy")
                                                    .ToList();
                }
                if (date == "week")
                {
                    var filter = filterBuilder.Gte(x => x.published_time, DateTime.UtcNow.AddDays(-7).Date);
                    data = _context.News.Aggregate().Match(x => x.status == 3 && x.news_title.ToLower().Contains(key.ToLower()))
                                                    .Match(x => x.news_category == category)
                                                    .Match(filter)
                                                    .SortByDescending(x => x.published_time)
                                                    .Lookup("Categories", "news_category", "_id", "categoriy")
                                                    .ToList();
                }
                if (date == "month")
                {
                    var filter = filterBuilder.Gte(x => x.published_time, DateTime.UtcNow.AddMonths(-1).Date);
                    data = _context.News.Aggregate().Match(x => x.status == 3 && x.news_title.ToLower().Contains(key.ToLower()))
                                                    .Match(x => x.news_category == category)
                                                    .Match(filter)
                                                    .SortByDescending(x => x.published_time)
                                                    .Lookup("Categories", "news_category", "_id", "categoriy")
                                                    .ToList();
                }
                if (date == "year")
                {
                    var filter = filterBuilder.Gte(x => x.published_time, DateTime.UtcNow.AddYears(-1).Date);
                    data = _context.News.Aggregate().Match(x => x.status == 3 && x.news_title.ToLower().Contains(key.ToLower()))
                                                    .Match(x => x.news_category == category)
                                                    .Match(filter)
                                                    .SortByDescending(x => x.published_time)
                                                    .Lookup("Categories", "news_category", "_id", "categoriy")
                                                    .ToList();
                }
            }
            else
            {

                if (date == "day")
                {
                    var filter = filterBuilder.Gte(x => x.published_time, DateTime.UtcNow.AddDays(-1).Date);
                    data = _context.News.Aggregate().Match(x => x.status == 3 && x.news_title.ToLower().Contains(key.ToLower()))
                                                    .Match(filter)
                                                    .SortByDescending(x => x.published_time)
                                                    .Lookup("Categories", "news_category", "_id", "categoriy")
                                                    .ToList();
                }
                if (date == "week")
                {
                    var filter = filterBuilder.Gte(x => x.published_time, DateTime.UtcNow.AddDays(-7).Date);
                    data = _context.News.Aggregate().Match(x => x.status == 3 && x.news_title.ToLower().Contains(key.ToLower()))
                                                    .Match(filter)
                                                    .SortByDescending(x => x.published_time)
                                                    .Lookup("Categories", "news_category", "_id", "categoriy")
                                                    .ToList();
                }
                if (date == "month")
                {
                    var filter = filterBuilder.Gte(x => x.published_time, DateTime.UtcNow.AddMonths(-1).Date);
                    data = _context.News.Aggregate().Match(x => x.status == 3 && x.news_title.ToLower().Contains(key.ToLower()))
                                                    .Match(filter)
                                                    .SortByDescending(x => x.published_time)
                                                    .Lookup("Categories", "news_category", "_id", "categoriy")
                                                    .ToList();
                }
                if (date == "year")
                {
                    var filter = filterBuilder.Gte(x => x.published_time, DateTime.UtcNow.AddYears(-1).Date);
                    data = _context.News.Aggregate().Match(x => x.status == 3 && x.news_title.ToLower().Contains(key.ToLower()))
                                                    .Match(filter)
                                                    .SortByDescending(x => x.published_time)
                                                    .Lookup("Categories", "news_category", "_id", "categoriy")
                                                    .ToList();
                }
            }
            var data_view = new List<NewsViewModel>();
            foreach (var item in data)
            {
                var news = new NewsViewModel();
                news._id = item["_id"].ToString();
                news.news_title = item["news_title"].ToString();
                news.news_excerpt = item["news_excerpt"].ToString();
                news.news_category = item["categoriy"].AsBsonArray[0]["category_name"].ToString();
                news.picture = item["picture"].ToString();
                if (item["published_time"].ToString() != "BsonNull")
                {
                    news.published_time = DateTime.Parse(item["published_time"].ToString());
                }
                news.total_views = Int32.Parse(item["total_views"].ToString());
                data_view.Add(news);
            }
            return data_view;
        }

        public News GetByIdNoJoin(string key)
        {
            return _context.News.Find(x => x._id == key).FirstOrDefault();
        }

        public List<News> GetNewManyViews()
        {
            var filterBuilder = Builders<News>.Filter;
            var filter = filterBuilder.Gte(x => x.published_time, DateTime.Now.AddDays(-7));
            return _context.News.Find(filter)
                                  .SortByDescending(x => x.total_views).Limit(6)
                                  .ToList();
        }

        public List<News> GetNewsManyViewsByCategory(string categoryId)
        {
            return _context.News.Find(x => x.status == 3 && x.news_category == categoryId).SortByDescending(x => x.total_views).Limit(6).ToList();
        }

        public bool CheckNewsTitleExists(string title, string categoryId)
        {
            var news = _context.News.Find(x => x.news_title.ToLower() == title.ToLower() && x.news_category == categoryId).FirstOrDefault();
            if (news != null)
            {
                return true;
            }
            return false;
        }

        public List<News> GetNewsByCategory2(string id)
        {
            return _context.News.Find(x => x.news_category == id).ToList();
        }

        public int NewsTotalByStatus(int status)
        {
            var total = 0;

            if (status == 0)
            {
                total = (int)_context.News.Find(FilterDefinition<News>.Empty).CountDocuments();
            }

            if (status == 1 || status == 2 || status == 3 || status == 4)
            {
                total = (int)_context.News.Find(x => x.status == status).CountDocuments();
            }
            if (status == 5)
            {
                var filterBuilder = Builders<News>.Filter;
                var filter = filterBuilder.Gte(x => x.published_time, DateTime.UtcNow.Date);
                total = (int)_context.News.Find(filter).CountDocuments();
            }

            return total;
        }

        public List<News> GetNewsByStatus(int status, int page, int page_size, string name, out long total_Page)
        {
            int skip = page_size * (page - 1);
            var total_document = _context.News.CountDocuments(x => x.status == status);

            if (!string.IsNullOrEmpty(name))
            {
                total_document = _context.News.CountDocuments(x => x.news_title.ToLower().Contains(name.ToLower()) && x.status == status);
            }
            total_Page = total_document % page_size == 0 ? total_document / page_size : total_document / page_size + 1;


            var data = _context.News.Find(x => x.status == status).SortByDescending(x => x.creation_time).Skip(skip).Limit(page_size).ToList();

            if (status == 3 || status == 4)
            {
                data = _context.News.Find(x => x.status == status).SortByDescending(x => x.published_time).Skip(skip).Limit(page_size).ToList();
            }

            if (!string.IsNullOrEmpty(name))
            {

                data = _context.News.Find(x => x.status == status && x.news_title.ToLower().Contains(name.ToLower())).SortByDescending(x => x.creation_time).Skip(skip).Limit(page_size).ToList();

                if (status == 3 || status == 4)
                {
                    data = _context.News.Find(x => x.status == status && x.news_title.ToLower().Contains(name.ToLower())).SortByDescending(x => x.published_time).Skip(skip).Limit(page_size).ToList();
                }
            }

            return data;
        }

        public List<News> GetNewsByCategoryPaging(string id, string search_String , int page , out long total_Page,out string catName)
        {
            int skip = 5 * (page - 1);
            var total_document = _context.News.CountDocuments(x => x.news_category == id);
            if (!string.IsNullOrEmpty(search_String))
            {
                total_document = _context.News.CountDocuments(x => x.news_category == id && x.news_title.ToLower().Contains(search_String.ToLower()));
            }
            catName = _context.Categories.Find(x => x._id == id).FirstOrDefault().category_name;
            total_Page = total_document % 5 == 0 ? total_document / 5 : total_document / 5 + 1;


            var data = _context.News.Find(x => x.news_category == id).SortByDescending(x => x.creation_time).Skip(skip).Limit(5).ToList();
            if (!string.IsNullOrEmpty(search_String))
            {
                data = _context.News.Find(x => x.news_category == id && x.news_title.ToLower().Contains(search_String.ToLower())).SortByDescending(x => x.published_time).Skip(skip).Limit(5).ToList();
            }

                return data;
        }

        public List<News> GetMyNews(string userId, string search_String, int page, out long total_Page, out  int TotalNews)
        {
            int pageSize = 5;
            int skip = pageSize * (page - 1);
            var total_document = _context.News.CountDocuments(x => x.user_id == userId);
            TotalNews = (int)total_document;
            if (!string.IsNullOrEmpty(search_String))
            {
                total_document = _context.News.CountDocuments(x=> x.news_title.ToLower().Contains(search_String.ToLower())&&  x.user_id == userId);
            }
            total_Page = total_document % pageSize == 0 ? total_document / pageSize : total_document / pageSize + 1;


            var data = _context.News.Find(x => x.user_id == userId).SortByDescending(x => x.creation_time).Skip(skip).Limit(pageSize).ToList();
            if (!string.IsNullOrEmpty(search_String))
            {
                data = _context.News.Find(x => x.user_id == userId && x.news_title.ToLower().Contains(search_String.ToLower())).SortByDescending(x => x.creation_time).Skip(skip).Limit(5).ToList();
            }

            return data;
        }
    }
}
