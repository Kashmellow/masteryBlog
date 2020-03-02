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


        public virtual CategoryModel Category { get; set; }
        public virtual int CategoryId { get; set; }

        public virtual TagModel Tag { get; set; }
        public virtual int TagId { get; set; }


        public BlogModel()
        {

        }

        public BlogModel(int id, string title, string content, string author, DateTime publishDate, int category, int tag)
        {
            BlogId = id;
            Title = title;
            Content = content;
            Author = author;
            PublishDate = publishDate;
            CategoryId = category;
            TagId = tag;

        }
    }


}
