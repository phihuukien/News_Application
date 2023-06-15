using BTLASPMONGO.Models.BusinessModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTLASPMONGO.Areas.ViewAdminComponents
{
    public class TotalNewsByCategoryViewComponent: ViewComponent
    {
        IRepositoryCategory repositoryCategory;
        IRepositoryNews repositoryNews;

        public TotalNewsByCategoryViewComponent(IRepositoryCategory repositoryCategory, IRepositoryNews repositoryNews)
        {
            this.repositoryCategory = repositoryCategory;
            this.repositoryNews = repositoryNews;
        }
        public IViewComponentResult Invoke(string cate_id)
        {
            ViewBag.TotalNews = repositoryNews.GetNewsByCategory2(cate_id).Count();
            return View();
        }
    }
}
