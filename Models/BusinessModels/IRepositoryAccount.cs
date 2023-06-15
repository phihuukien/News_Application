using BTLASPMONGO.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTLASPMONGO.Models.BusinessModels
{
    public interface IRepositoryAccount: IRepositoryGeneric<Account , string>
    {
        public Account Account_Check(string username, string password);
    }
}
