using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace masteryBlog.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<BlogModel> Blogs { get; set; }

        public CategoryModel()
        {

        }

        public CategoryModel(int catid, string catname)
        {
            CategoryId = catid;
            CategoryName = catname;
        }
    }
}
