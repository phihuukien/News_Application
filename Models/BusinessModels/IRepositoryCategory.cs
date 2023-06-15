using BTLASPMONGO.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTLASPMONGO.Models.BusinessModels
{
    public interface IRepositoryCategory: IRepositoryGeneric<Category,string>
    {
        public List<Category> Pageing(int page, int page_size,string name,string sort,out long total_Page);

        public List<Category> GetByStatus();

        public bool CheckName(string name);


    }
}
