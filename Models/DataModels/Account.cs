using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace BTLASPMONGO.Models.DataModels
{
    public class Account
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string _id { get; set; }

        [BsonElement]
        [BsonRequired]
        public string username { get; set; }

        [BsonElement]
        [BsonRequired]
        public string password { get; set; }

        [BsonElement]
        public string fullname { get; set; }

        [BsonElement]
        public string avatar { get; set; }


        [BsonElement]
        public string role { get; set; }

        [BsonElement]
        public int status { get; set; }
    }
}
