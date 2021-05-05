using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace WebApplication1.Controllers
{
    public class ContactsController : Controller
    {
        private IContactService _contactService;

        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult getAll()
        {
            var result = _contactService.GetAll();
            if (result.Success)
            {
                return View(result.Data);
            }
            return BadRequest(result.Message);
        }

        public IActionResult Add(Contact contact)
        {
            var result = _contactService.Add(contact);
            if (result.Success)
            {
                return View(result);
            }
            return BadRequest(result.Message);
        }
        public IActionResult Delete(Contact contact)
        {
            var result = _contactService.Delete(contact);
            if (result.Success)
            {
                return View(result);
            }
            return BadRequest(result.Message);
        }
        public IActionResult Update(Contact contact)
        {
            var result = _contactService.Update(contact);
            if (result.Success)
            {
                return View(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
