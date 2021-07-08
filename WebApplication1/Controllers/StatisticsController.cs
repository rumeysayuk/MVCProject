using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace WebApplication1.Controllers
{
    public class StatisticsController : Controller
    {
        Context _context = new Context();
        public IActionResult Index()
        {
            var ToplamKategori = _context.Categories.Count(); //Toplam Kategori Sayisi
            ViewBag.ToplamKategoriSayısı = ToplamKategori;

            var YazılımKategorisi = _context.Headings.Count(x => x.Id == 1); // Yazilim Kategorisi id 8, başlik sayisi
            ViewBag.YazılımKategorisisBasNum = YazılımKategorisi;

            var ŞartlıYazarAdı = _context.Writers.Count(x => x.Firstname.Contains("a")); // Yazar adinda "a" harfi gecen yazar sayisi
            ViewBag.ŞartlıYazarAdımız = ŞartlıYazarAdı;

            var EnFazlaBaşlık = _context.Headings.Where(u => u.Id == _context.Headings.GroupBy(x => x.Id).OrderByDescending(x => x.Count())
                .Select(x => x.Key).FirstOrDefault()).Select(x => x.Name).FirstOrDefault(); // En fazla basliga sahip kategori adi
            ViewBag.EnFazlaBaşlığımız = EnFazlaBaşlık;

            var DurumuTrueOlanKategoriler = _context.Categories.Count(x => x.Status == true); // Kategoriler tablosundaki aktif kategori sayisi
            ViewBag.AktifKategoriler = DurumuTrueOlanKategoriler;
            return View();

        }
    }
}
