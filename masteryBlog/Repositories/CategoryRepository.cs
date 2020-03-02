using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using masteryBlog.Models;

namespace masteryBlog.Repositories
{
    public class CategoryRepository : Repository<CategoryModel>
    {
        public CategoryRepository(BlogContext context) : base(context)
        {
            // This ensures our base constructor gets run.
        }
    }
}
