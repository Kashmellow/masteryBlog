using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace masteryBlog.Repositories
{
    public class TagRepositoryTagRepository : Repository<TagModel>
    {
        public TagRepository(BlogContext context) : base(context)
        {
            // This ensures our base constructor gets run.
        }
    }
}
