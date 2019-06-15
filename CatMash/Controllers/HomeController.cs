using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CatMash.Models;

namespace CatMash.Controllers
{
    /*
     * Class : HomeController
     * Handles the operations on the homepage of CatMash
     * Author : automatically generated, Mokrane added a few methods
     */
    public class HomeController : Controller
    {

        public HomeController()
        {
            if(Cats.ready == false)
                Cats.GatherCats();
        }

        public IActionResult Index()
        {
            CatRandomizer randy = new CatRandomizer();
            randy.ChooseCandidates();
            ViewBag.first = Cats.cats[randy.firstIndex].url;
            ViewBag.firstIndex = randy.firstIndex;
            ViewBag.sec = Cats.cats[randy.secondIndex].url;
            ViewBag.secondIndex = randy.secondIndex;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Voted(int catIndex)
        {
            Cats.AddVote(catIndex);

            CatRandomizer randy = new CatRandomizer();
            randy.ChooseCandidates();
            ViewBag.first = Cats.cats[randy.firstIndex].url;
            ViewBag.sec = Cats.cats[randy.secondIndex].url;
            ViewBag.firstIndex = randy.firstIndex;
            ViewBag.secondIndex = randy.secondIndex;

            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
