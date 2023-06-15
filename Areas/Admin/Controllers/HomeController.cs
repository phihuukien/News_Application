using AspNetCoreHero.ToastNotification.Abstractions;
using BTLASPMONGO.Models.BusinessModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTLASPMONGO.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin")]
    [Authorize]
    public class HomeController : Controller
    {
        IRepositoryCategory repositoryCategory;
        IRepositoryNews repositoryNews;
        private readonly INotyfService _notyf;

        public HomeController(IRepositoryCategory repositoryCategory, IRepositoryNews repositoryNews, INotyfService notyf)
        {
            this._notyf = notyf;
            this.repositoryCategory = repositoryCategory;
            this.repositoryNews = repositoryNews;
        }

        [Route("")]
        public IActionResult Index()
        {
            ViewBag.NewsTotal = repositoryNews.NewsTotalByStatus(0);
            ViewBag.NewsTotalLocked = repositoryNews.NewsTotalByStatus(4);
            ViewBag.NewsTotalApproving = repositoryNews.NewsTotalByStatus(1);
            ViewBag.NewsTotalWriting = repositoryNews.NewsTotalByStatus(2);
            ViewBag.NewsTotalPublished = repositoryNews.NewsTotalByStatus(3);
            ViewBag.NewsTotalToday = repositoryNews.NewsTotalByStatus(5);

            return View();
        }

      
    }
}
