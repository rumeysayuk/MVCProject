using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace WebApplication1.Controllers
{
    public class HeadingsController : Controller
    {
        private IHeadingService _headingService;

        public HeadingsController(IHeadingService headingService)
        {
            _headingService = headingService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult getAll()
        {
            var result = _headingService.GetAll();
            if (result.Success)
            {
                return View(result.Data);
            }
            return BadRequest(result.Message);
        }

        public IActionResult Add(Heading heading)
        {
            var result = _headingService.Add(heading);
            if (result.Success)
            {
                return View(result.Message);
            }
            return BadRequest(result.Message);
        }
        public IActionResult Delete(Heading heading)
        {
            var result = _headingService.Delete(heading);
            if (result.Success)
            {
                return View(result);
            }
            return BadRequest(result.Message);
        }
        public IActionResult Update(Heading heading)
        {
            var result = _headingService.Update(heading);
            if (result.Success)
            {
                return View(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
