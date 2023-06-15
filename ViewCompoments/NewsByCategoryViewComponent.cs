using BTLASPMONGO.Models.BusinessModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTLASPMONGO.ViewCompoments
{
    public class NewsByCategoryViewComponent: ViewComponent
    {
        IRepositoryCategory repositoryCategory;
        IRepositoryNews repositoryNews;

        public NewsByCategoryViewComponent(IRepositoryCategory repositoryCategory, IRepositoryNews repositoryNews)
        {
            this.repositoryCategory = repositoryCategory;
            this.repositoryNews = repositoryNews;
        }
        public IViewComponentResult Invoke(string cate_id)
        {
            var data = repositoryNews.Get_News_By_Category(cate_id).Skip(1).Take(3);
            ViewData["data_first_cat"] = repositoryNews.Get_News_By_Category(cate_id).FirstOrDefault();
            return View(data);
        }
    }
}
