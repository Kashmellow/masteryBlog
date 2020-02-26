using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace masteryBlog.Models
{
    public class BlogModel
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
        public string Category { get; set; }
        public string Tag { get; set; }

        public BlogModel()
        {

        }

        public BlogModel(int id, string title, string content, string author, DateTime publishDate, string category, string tag)
        {
            BlogId = id;
            Title = title;
            Content = content;
            Author = author;
            PublishDate = publishDate;
            Category = category;
            Tag = tag;

        }
    }


}
