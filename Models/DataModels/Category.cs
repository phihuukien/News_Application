using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BTLASPMONGO.Models.DataModels
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string _id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Độ dài danh mục từ 4->50")]
        [BsonElement]
        public string category_name { get; set; }

        [BsonElement]
        public bool status { get; set; }

        [BsonElement]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime creation_time { get; set; }

    }
}
