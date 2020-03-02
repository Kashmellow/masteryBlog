using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace masteryBlog.Models
{
    public class TagModel
    {
        public int TagId { get; set; }
        public string TagName { get; set; }

        public virtual ICollection<BlogModel> Blogs { get; set; }

        public TagModel()
        {

        }

        public TagModel(int tagId, string tagName)
        {
            TagId = tagId;
            TagName = tagName;
        }
    }
}
