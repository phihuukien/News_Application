using AspNetCoreHero.ToastNotification.Abstractions;
using BTLASPMONGO.Models.BusinessModels;
using BTLASPMONGO.Models.DataModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTLASPMONGO.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/category")]
    [Authorize]
    public class CategoryController : Controller
    {
        IRepositoryCategory repositoryCategory;
        IRepositoryNews repositoryNews;
        private readonly INotyfService _notyf;

        public CategoryController(IRepositoryCategory repositoryCategory, IRepositoryNews repositoryNews, INotyfService notyf)
        {
            this._notyf = notyf;
            this.repositoryCategory = repositoryCategory;
            this.repositoryNews = repositoryNews;
        }

        [Route("")]
        public IActionResult Index(string name = "", string sort = "", int page = 1)
        {
            page = page < 1 ? 1 : page;
            long total_Page;
            var data = repositoryCategory.Pageing(page, 5, name, sort, out total_Page);
            ViewBag.total_Page = total_Page;
            ViewBag.name = name;
            ViewBag.sort = sort;
            ViewBag.page = page;
            return View(data);
        }
        [Route("create")]
        public PartialViewResult Create()
        {
            return PartialView();
        }

        [Route("save")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(Category category)
        {
            if (ModelState.IsValid)
            {
                if (repositoryCategory.CheckName(category.category_name))
                {
                    TempData["error"] = "Tên này đã tồn tại";
                    TempData["name"] = category.category_name;
                    return RedirectToAction(nameof(Index));
                }
                category.category_name = category.category_name.ToUpper().Trim();
                category.creation_time = DateTime.Now;
                category.status = false;
                repositoryCategory.Insert(category);
                _notyf.Success("Success Insert", 4);
                return RedirectToAction(nameof(Index));
            }
            TempData["name"] = category.category_name;
            TempData["error"] = "Tên trống";
            return RedirectToAction(nameof(Index));

        }




        [Route("change-status")]
        [HttpPost]
        public IActionResult ChangeStatus([FromForm] Category category)
        {
            var cat = repositoryCategory.GetById(category._id);
            if (category.status == true)
            {
                var dataNews = repositoryNews.GetNewsByCategory2(cat._id);
                foreach (var item in dataNews)
                {
                    if (item.status == 4)
                    {
                        item.status = 3;
                        repositoryNews.Update(item);
                    }
                }
            }
            else
            {
                var dataNews = repositoryNews.GetNewsByCategory2(cat._id);
                foreach (var item in dataNews)
                {
                    if (item.status == 3)
                    {
                        item.status = 4;
                        repositoryNews.Update(item);
                    }
                }
            }
            cat.status = category.status;
            repositoryCategory.Update(cat);
            return Ok(new { Message = "Success update" });
        }
        [Route("rename")]
        public PartialViewResult Rename(string id)
        {
            var category = repositoryCategory.GetById(id);
            return PartialView(category);
        }
        [Route("save-name")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveName(Category category)
        {
            var cat = repositoryCategory.GetById(category._id);
            cat.category_name = category.category_name;
            cat.creation_time = DateTime.Now;
            repositoryCategory.Update(cat);
            _notyf.Success("Success Rename", 4);
            return RedirectToAction(nameof(Index));
        }

        [Route("delete/{id}")]
        public IActionResult Delete(string id)
        {
            var dataNews = repositoryNews.GetNewsByCategory2(id);
            foreach (var item in dataNews)
            {
                repositoryNews.Delete(item._id);
            }
            repositoryCategory.Delete(id);
            _notyf.Success("Success Delete", 4);
            return RedirectToAction(nameof(Index));
        }

    }
}
