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
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BlogModel blog)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            blogRepo.Create(blog);
            return RedirectToAction("Index");
        }


 

        [HttpGet]
        public ViewResult Update(int id)
        {
            var model = blogRepo.GetById(id);
            return View(model);
        }

        //Breaking Here
        [HttpPost]
        public ActionResult Update(BlogModel blog)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            blogRepo.Update(blog);
            return RedirectToAction("Detail", "Blog", new { id = blog.Id });
        }


        [HttpGet]
        public ViewResult Delete(int id)
        {
            BlogModel model = blogRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(BlogModel blog)
        {
            blogRepo.Delete(blog);
            return RedirectToAction("Index", "Blog");
        }


    }
}