using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace WebApplication1.Controllers
{
    public class AboutsController : Controller
    {
        private IAboutService _aboutService;

        public AboutsController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult getAll()
        {
            var result = _aboutService.GetAll();
            if (result.Success)
            {
                return View(result.Data);
            }
            return BadRequest(result.Message);
        }

        public IActionResult Add(About about)
        {
            var result = _aboutService.Add(about);
            if (result.Success)
            {
                return View(result.Message);
            }
            return BadRequest(result.Message);
        }
        public IActionResult Delete(About about)
        {
            var result = _aboutService.Delete(about);
            if (result.Success)
            {
                return View(result);
            }
            return BadRequest(result.Message);
        }
        public IActionResult Update(About about)
        {
            var result = _aboutService.Update(about);
            if (result.Success)
            {
                return View(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
