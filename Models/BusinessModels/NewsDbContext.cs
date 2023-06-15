using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTLASPMONGO.Models.DataModels;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace BTLASPMONGO.Models.BusinessModels
{
    public class NewsDbContext
    {
        IConfiguration Configuration;
        public NewsDbContext(IConfiguration Configuration)
        {
            this.Configuration = Configuration;
        }
        public IMongoDatabase Connection
        {
            get
            {
                var client = new MongoClient(Configuration.GetConnectionString("MongoConnection"));
                var database = client.GetDatabase(Configuration.GetConnectionString("database"));
                return database;
            }
        }
        public IMongoCollection<Category> Categories => Connection.GetCollection<Category>("Categories");
        public IMongoCollection<News> News => Connection.GetCollection<News>("News");
        public IMongoCollection<Account> Account => Connection.GetCollection<Account>("Account");



    }
}
