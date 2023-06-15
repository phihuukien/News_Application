using BTLASPMONGO.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace BTLASPMONGO.Models.BusinessModels
{
    public class RepositoryAccount : IRepositoryAccount
    {
        NewsDbContext _context;
        public RepositoryAccount(NewsDbContext _context)
        {
            this._context = _context;
        }

        public Account Account_Check(string username, string password)
        {
            return _context.Account.Find(x => x.username == username && x.password == password).FirstOrDefault();
        }

        public bool Delete(string key)
        {
            throw new NotImplementedException();
        }

        public List<Account> GetAll()
        {
            throw new NotImplementedException();
        }

        public Account GetById(string key)
        {
           return _context.Account.Find(x=> x._id == key).FirstOrDefault();
        }

        public bool Insert(Account entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Account entity)
        {
            throw new NotImplementedException();
        }
    }
}
