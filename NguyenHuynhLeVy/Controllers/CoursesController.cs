using NguyenHuynhLeVy.Models;
using NguyenHuynhLeVy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenHuynhLeVy.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Courses
        public ActionResult Create()
        {
            var viewModel = new CourseViewModels
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }
    }
}