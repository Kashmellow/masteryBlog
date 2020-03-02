﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using masteryBlog.Models;

namespace masteryBlog.Repositories
{
    public class TagRepository : Repository<TagModel>
    {
        public TagRepository(BlogContext context) : base(context)
        {
            // This ensures our base constructor gets run.
        }
    }
}
