using masteryBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace masteryBlog.Repositories
{
    public class BlogRepository : Repository<BlogModel>
    {
        public BlogRepository(BlogContext context) : base(context)
        {

        }
    }
}
