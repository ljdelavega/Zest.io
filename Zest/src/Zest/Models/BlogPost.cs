using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zest.Models
{
    public class BlogPost
    {
        public string title { get; set; }
        public int id { get; set; }
        public DateTime postedOn { get; set; }
        public string author { get; set; }
        public string summary { get; set; }
        public string body { get; set; }
        public string imgName { get; set; } // name of the image located in wwwroot/images

        public BlogPost(string title, int id, DateTime postedOn, string author, string summary, string body, string img)
        {
            this.title = title;
            this.id = id;
            this.postedOn = postedOn;
            this.author = author;
            this.summary = summary;
            this.body = body;
            this.imgName = img;
        }
    }
}
