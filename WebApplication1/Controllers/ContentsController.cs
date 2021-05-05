using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace WebApplication1.Controllers
{
    public class ContentsController : Controller
    {
        private IContentService _contentService;

        public ContentsController(IContentService contentService)
        {
            _contentService = contentService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult getAll()
        {
            var result = _contentService.GetAll();
            if (result.Success)
            {
                return View(result.Data);
            }
            return BadRequest(result.Message);
        }

        public IActionResult Add(Content content)
        {
            var result = _contentService.Add(content);
            if (result.Success)
            {
                return View(result.Message);
            }
            return BadRequest(result.Message);
        }
        public IActionResult Delete(Content content)
        {
            var result = _contentService.Delete(content);
            if (result.Success)
            {
                return View(result);
            }
            return BadRequest(result.Message);
        }
        public IActionResult Update(Content content)
        {
            var result = _contentService.Update(content);
            if (result.Success)
            {
                return View(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
