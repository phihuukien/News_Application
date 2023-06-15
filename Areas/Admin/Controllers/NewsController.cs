using AspNetCoreHero.ToastNotification.Abstractions;
using BTLASPMONGO.Models.BusinessModels;
using BTLASPMONGO.Models.DataModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace BTLASPMONGO.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/news")]
    [Authorize]
    public class NewsController : Controller
    {
        IRepositoryCategory repositoryCategory;
        IRepositoryNews repositoryNews;
        private readonly INotyfService _notyf;

        public NewsController(IRepositoryCategory repositoryCategory, IRepositoryNews repositoryNews, INotyfService notyf)
        {
            this._notyf = notyf;
            this.repositoryCategory = repositoryCategory;
            this.repositoryNews = repositoryNews;
        }
        [Route("")]
        public IActionResult News(string search_String = "", string sort = "", string sortBy="" , int page = 1)
        {
            page = page < 1 ? 1 : page;
            long total_Page;
            var data = repositoryNews.Get_All_News(page, 5, search_String, sort, sortBy, out total_Page);
            ViewBag.total_Page = total_Page;
            ViewBag.search_String = search_String;
            ViewBag.sort = sort;
            ViewBag.sortBy = sortBy;
            ViewBag.page = page;
            return View(data);
        }
        [Route("create")]
        public IActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(repositoryCategory.GetAll(), "_id", "category_name");
            return View();
        }
        [Route("save")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save_News(News news, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                if (repositoryNews.CheckNewsTitleExists(news.news_title,news.news_category))
                {
                    TempData["error"] = "Tiêu đề này đã tồn tại";
                    ViewBag.CategoryId = new SelectList(repositoryCategory.GetAll(), "_id", "category_name");
                    return View("Create");
                }

                if (image == null)
                {
                    TempData["errorPicture"] = "Chưa có ảnh tin tức";
                    ViewBag.CategoryId = new SelectList(repositoryCategory.GetAll(), "_id", "category_name");
                    return View("Create");
                }
                news.picture = repositoryNews.UploadFile(image);
                news.creation_time = DateTime.Now;
                news.last_modification_time = DateTime.Now;
                news.user_id = @User.Claims.Skip(4).FirstOrDefault().Value;
                news.total_views = 0;
                news.news_slug = "abc-ada";

                repositoryNews.Insert(news);
                _notyf.Success("Tạo tin thành công", 4);
                return RedirectToAction(nameof(News));
            }
            ViewBag.CategoryId = new SelectList(repositoryCategory.GetAll(), "_id", "category_name");
            return View("Create");

        }

        [Route("delete/{id}")]
        public IActionResult Delete(string id)
        {

            repositoryNews.Delete(id);
            _notyf.Success("Success Delete", 4);
            return RedirectToAction(nameof(News));
        }
        [Route("detail")]
        public IActionResult Detail(string id)
        {
            var data = repositoryNews.GetById(id);
            return View(data);
        }
        [Route("edit")]
        public IActionResult Edit(string id)
        {
            ViewBag.CategoryId = new SelectList(repositoryCategory.GetAll(), "_id", "category_name");
            var data = repositoryNews.GetByIdToChange(id);
            ViewBag.Picture = data.picture; 
            return View(data);
        }
        [Route("update")]
        public IActionResult Update(News news, IFormFile image,string OldImage)
        {
            if (image == null)
            {
                news.picture = OldImage;
            }
            else
            {
                news.picture = repositoryNews.UploadFile(image);
            }
            news.last_modification_time = DateTime.Now;
            if(news.published_time == null && news.status == 3)
            {
                news.published_time = DateTime.Now;
            }
            repositoryNews.Update(news);
            _notyf.Success("Success Update", 4);
            return RedirectToAction(nameof(News));
        }
        [Route("change-status")]
        [HttpPost]
        public IActionResult ChangeStatus([FromForm] News news)
        {
            var news_entity = repositoryNews.GetByIdToChange(news._id);
            var category = repositoryCategory.GetById(news_entity.news_category);
            if (category.status == false && news.status == 3)
            {
                return BadRequest("Vui lòng kích hoạt danh mục của tin này !");
            }
            else
            {
                if (news_entity.published_time == null)
                {
                    news_entity.published_time = DateTime.Now;
                }
                news_entity.status = news.status;
                repositoryNews.Update(news_entity);
                return Ok(new { Message = "Success change" });
            }
        }

        [Route("status/{status}")]
        public IActionResult GetNewsByStatus(int status, string search_String = "", int page = 1)
        {
            page = page < 1 ? 1 : page;
            long total_Page;
            var data = repositoryNews.GetNewsByStatus(status,page,4,search_String,out total_Page);
            ViewBag.total_Page = total_Page;
            ViewBag.search_String = search_String;
            ViewBag.page = page;
            ViewBag.Status = status;
            return View(data);
        }
        [Route("bycategory/{id}")]
        public IActionResult GetNewsByCategory(string id, string search_String = "", int page = 1)
        {
            page = page < 1 ? 1 : page;
            long total_Page;
            string catName;
            var data = repositoryNews.GetNewsByCategoryPaging(id, search_String, page, out total_Page, out catName);
            ViewBag.total_Page = total_Page;
            ViewBag.search_String = search_String;
            ViewBag.page = page;
            ViewBag.catId = id;
            ViewBag.catName = catName;
            return View(data);
        }

        [Route("my-news")]
        public IActionResult GetMyNews(int page =1,string search_String = "")
        {
            long total_Page;
            int TotalNews;
            var data = repositoryNews.GetMyNews(@User.Claims.Skip(4).FirstOrDefault().Value.ToString(), search_String,page,out total_Page,out TotalNews);
            ViewBag.total_Page = total_Page;
            ViewBag.search_String = search_String;
            ViewBag.page = page;
            ViewBag.TotalNews = TotalNews;
            return View(data);
        }

    }
}
