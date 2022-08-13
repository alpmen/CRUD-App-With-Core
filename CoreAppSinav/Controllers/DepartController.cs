using CoreAppSinav.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAppSinav.Controllers
{
    public class DepartController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult PageDepartman()
        {
            var departList = c.GorevDepartmans.ToList();
            return View(departList);
        }

        [HttpGet]
        public IActionResult YeniDepartman()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YeniDepartman(Departmanlar d)
        {
            c.GorevDepartmans.Add(d);
            c.SaveChanges();
            return RedirectToAction("PageDepartman");
        }


        public IActionResult SilDepartman(int ID)
        {
            var d = c.GorevDepartmans.Find(ID);
            c.GorevDepartmans.Remove(d);
            c.SaveChanges();
            return RedirectToAction("PageDepartman");
        }


        public IActionResult GuncelleDepartman(int ID)
        {
            var d = c.GorevDepartmans.Find(ID);
            return View("GuncelleDepartman",d);
        }

        public IActionResult DepartmanGuncelle(Departmanlar d)
        {
            var dep = c.GorevDepartmans.Find(d.ID);
            dep.DepartmanAd = d.DepartmanAd;
            dep.Detay = d.Detay;
            c.SaveChanges();
            return RedirectToAction("PageDepartman");
        }





    }
}
