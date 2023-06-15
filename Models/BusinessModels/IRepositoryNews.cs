using BTLASPMONGO.Models.DataModels;
using BTLASPMONGO.ViewModel;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTLASPMONGO.Models.BusinessModels
{
    public interface IRepositoryNews:IRepositoryGeneric<News,string>
    {
        public string UploadFile(IFormFile image);

        public List<News> Get_All_News(int page, int page_size, string name, string sort_Order,string sort_Order_By, out long total_Page);

        public List<News> Get_News_By_Category(string id);

        public News GetByIdToChange(string key);

        public List<NewsViewModel> NewsSearch(string key, string date, string category);
        public News GetByIdNoJoin(string key);
        public List<NewsViewModel> GetAllNewsModel();

        public List<News> GetNewManyViews();

        public List<News> GetNewsManyViewsByCategory(string categoryId);

        public bool CheckNewsTitleExists(string title,string categoryId);

        public List<News> GetNewsByCategory2(string id);

        public int NewsTotalByStatus(int status);

        public List<News> GetNewsByStatus(int status, int page, int page_size, string name, out long total_Page);

        public List<News> GetNewsByCategoryPaging(string id, string search_String , int page, out long total_Page, out string catName);

        public List<News> GetMyNews(string userId, string search_String, int page, out long total_Page, out int TotalNews);
   
    }
}
