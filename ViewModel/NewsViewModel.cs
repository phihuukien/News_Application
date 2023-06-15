using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTLASPMONGO.ViewModel
{
    public class NewsViewModel
    { 
        public string _id { get; set; }
        public string news_title { get; set; }

        public string news_excerpt { get; set; }

        public string userName { get; set; }
        public string userId { get; set; }

        public string news_content { get; set; }

        public string picture { get; set; }

        public string news_slug { get; set; }
        public string news_category { get; set; }
        public string categoryId { get; set; }
        public DateTime? published_time { get; set; }
        public DateTime creation_time { get; set; }
        public DateTime? last_modification_time { get; set; }

        public int? total_views { get; set; }

        public int status { get; set; }

    }
}
