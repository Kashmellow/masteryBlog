using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using masteryBlog.Models;
using masteryBlog.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace masteryBlog.Controllers
{
    public class BlogController : Controller
    {
        IRepository<BlogModel> blogRepo;

        public BlogController(IRepository<BlogModel> blogRepo)
        {
            this.blogRepo = blogRepo;
        }
        public ViewResult Index()
        {
            var model = blogRepo.GetAll();

            return View(model);
        }

        public ViewResult Detail(int id)
        {
            var model = blogRepo.GetById(id);

            return View(model);
        }
    }
}