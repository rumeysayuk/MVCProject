using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace WebApplication1.Controllers
{
    public class AdminCategoriesController : Controller
    {
        private ICategoryService _categoryService;

        public AdminCategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var result = _categoryService.GetAll();
            if (result.Success)
            {
                return View(result.Data);
            }

            return BadRequest(result.Message);

        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Category category)
        {
            var result = _categoryService.Add(category);
            if (result.Success)
            {
                return RedirectToAction("Index");

            }

            return BadRequest(result.Message);
        }

        [HttpGet]
        public IActionResult Delete(Category category)
        {
            var result = _categoryService.Delete(category);
            if (result.Success)
            {
                return RedirectToAction("Index");

            }

            return BadRequest(result.Message);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var result = _categoryService.GetById(id);
            if (result.Success)
            {
                return View(result);
            }

            return BadRequest(result.Message);
        }

        [HttpPost]
        public IActionResult Update(Category category)
        {
            var result = _categoryService.Update(category);
            if (result.Success)
            {
                return RedirectToAction("Index");
            }

            return BadRequest(result.Message);
        }
    }
}
