using BTLASPMONGO.Models;
using BTLASPMONGO.Models.BusinessModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BTLASPMONGO.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IRepositoryCategory repositoryCategory;
        IRepositoryNews repositoryNews;
        public HomeController(IRepositoryCategory repositoryCategory, IRepositoryNews repositoryNews, ILogger<HomeController> logger)
        {
            _logger = logger;
            this.repositoryCategory = repositoryCategory;
            this.repositoryNews = repositoryNews;
        }
        [Route("")]
        public IActionResult Index()
        {
            HttpContext.Session.SetString("activeBy", "home");
            ViewData["data_first"]  = repositoryNews.GetAllNewsModel().FirstOrDefault();
            var total_document = repositoryNews.GetAllNewsModel().Count();
            ViewBag.total_Page = total_document % 5 == 0 ? total_document / 5 : total_document / 5 + 1;
            var data = repositoryNews.GetAllNewsModel().Skip(1).Take(4);
            ViewData["Categories"] = repositoryCategory.GetByStatus();
            ViewData["dataManyViews"] = repositoryNews.GetNewManyViews();
            return View(data);
        }

        [Route("get-more-records")]
        public IActionResult GetMoreRecords(int page = 1, int pageSize = 5)
        {
            var data = repositoryNews.GetAllNewsModel().Skip(((page - 1) * pageSize)).Take(pageSize);
            return PartialView("_RecordsPartial", data);
        }

        [Route("search")]
        public IActionResult NewsSearch(string key, string date, string category)
        {
            ViewBag.CategoryId = new SelectList(repositoryCategory.GetByStatus(), "_id", "category_name",category);
            var data = repositoryNews.NewsSearch(key, date, category).Take(5);
            var total_document = repositoryNews.NewsSearch(key, date, category).Count();
            ViewBag.total_Page = total_document % 5 == 0 ? total_document / 5 : total_document / 5 + 1;
            ViewBag.Key = key;
            ViewBag.Date = date;
            ViewBag.category = category;
            return View(data);
        }

        [Route("get-more-records-search")]
        public IActionResult GetMoreRecordsBySearch(string key, string date, string category, int page = 1)
        {
            int pageSize = 5;
            var data = repositoryNews.NewsSearch(key, date, category).Skip(((page - 1) * pageSize)).Take(pageSize);
            return PartialView("_RecordsPartial", data);
        }


        [Route("detail")]
        public IActionResult NewsDetail(string id)
        {
            
            var data = repositoryNews.GetById(id);
            var news = repositoryNews.GetByIdNoJoin(id);
            HttpContext.Session.SetString("activeBy",data.news_category );
            news.total_views = news.total_views + 1;
            repositoryNews.Update(news);
            ViewData["data"] = repositoryNews.Get_News_By_Category(news.news_category);
            return View(data);
        }


       
        [Route("category")]
        public IActionResult GetNewsByCategory(string id)
        {
            var catName =  repositoryCategory.GetById(id).category_name;
            ViewBag.CatName = catName;
            HttpContext.Session.SetString("activeBy", catName);
            ViewBag.CatId = repositoryCategory.GetById(id)._id;
            var total_document = repositoryNews.Get_News_By_Category(id).Skip(4).Count();
            ViewBag.total_Page = total_document % 5 == 0 ? total_document / 5 : total_document / 5 + 1;
            ViewData["data_first"] = repositoryNews.Get_News_By_Category(id).FirstOrDefault();
            ViewData["data_three"] = repositoryNews.Get_News_By_Category(id).Skip(1).Take(3);
            var data = repositoryNews.Get_News_By_Category(id).Skip(4).Take(5);

            ViewData["dataByTotalView"] = repositoryNews.GetNewsManyViewsByCategory(id);
            return View(data);
        }

        [Route("get-more-records-byCategory")]
        public IActionResult GetMoreRecordsByCategory(string category_id, int page = 1)
        {
            int pageSize = 5;
            var data = repositoryNews.Get_News_By_Category(category_id).Skip(((page - 1) * pageSize)+4).Take(pageSize);
            return PartialView("_RecordsByCategoryPartial", data);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
