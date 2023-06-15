using BTLASPMONGO.Models.BusinessModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTLASPMONGO.ViewCompoments
{
    public class CategoryViewComponent : ViewComponent
    {
        IRepositoryCategory repositoryCategory;

        public CategoryViewComponent(IRepositoryCategory repositoryCategory)
        {
            this.repositoryCategory = repositoryCategory;
        }
        public IViewComponentResult Invoke()
        {
            var data = repositoryCategory.GetByStatus();
            return View(data);
        }
    }
}
