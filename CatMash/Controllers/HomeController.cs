using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CatMash.Models;

namespace CatMash.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Cats cats = new Cats();
            cats.GatherCats();
            CatRandomizer randy = new CatRandomizer();
            randy.ChooseCandidates(cats);
            ViewBag.first = cats.cats[randy.firstIndex].url;
            ViewBag.sec = cats.cats[randy.secondIndex].url;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
