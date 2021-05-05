using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace WebApplication1.Controllers
{
    public class WritersController : Controller
    {
        private IWriterService _writerService;

        public WritersController(IWriterService writerService)
        {
            _writerService = writerService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult getAll()
        {
            var result = _writerService.GetAll();
            if (result.Success)
            {
                return View(result.Data);
            }
            return BadRequest(result.Message);
        }

        public IActionResult Add(Writer writer)
        {
            var result = _writerService.Add(writer);
            if (result.Success)
            {
                return View(result.Message);
            }
            return BadRequest(result.Message);
        }
        public IActionResult Delete(Writer writer)
        {
            var result = _writerService.Delete(writer);
            if (result.Success)
            {
                return View(result);
            }
            return BadRequest(result.Message);
        }
        public IActionResult Update(Writer writer)
        {
            var result = _writerService.Update(writer);
            if (result.Success)
            {
                return View(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
