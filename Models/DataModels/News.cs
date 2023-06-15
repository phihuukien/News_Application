using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BTLASPMONGO.Models.DataModels
{
    public class News
    {

        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)] 
        public string _id { get; set; }

        [Required(ErrorMessage ="Tiêu đề không được trống")]
        [StringLength(150,MinimumLength = 15 ,ErrorMessage = "Độ dài tiêu đề từ 15-> 150")]
        [BsonElement]
        public string news_title { get; set; }

        [Required(ErrorMessage = "Trích đoạn không được trống")]
        [StringLength(500, MinimumLength = 25, ErrorMessage = "Độ dài trích đoạn từ 20-> 500")]
        [BsonElement]
        public string news_excerpt { get; set; }

        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        [BsonElement]
        public string user_id { get; set; }

        [Required(ErrorMessage = "Nội dung tin tức trống")]
        [MinLength(500, ErrorMessage = "Nội dung tin tức phải > 500 ky tự")]
        [BsonElement]
        public string news_content { get; set; }

        [BsonElement]
        public string picture { get; set; }

        [BsonElement]
        public string news_slug { get; set; }

        [BsonElement]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string news_category { get; set; }

        [BsonElement]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime? published_time { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        [BsonElement]
        public DateTime creation_time { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        [BsonElement]
        public DateTime? last_modification_time { get; set; }

        [BsonElement]
        public int? total_views { get; set; }

        [BsonElement]
        public int status { get; set; }


    }
}
