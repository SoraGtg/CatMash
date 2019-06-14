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
        private Cats cats;

        public HomeController()
        {
            this.cats = new Cats();
            cats.GatherCats();
            ViewBag.totalVotes = SharedVariables.totalVotes;
        }

        public IActionResult Index()
        {
            CatRandomizer randy = new CatRandomizer();
            randy.ChooseCandidates(this.cats);
            ViewBag.first = this.cats.cats[randy.firstIndex].url;
            ViewBag.firstIndex = randy.firstIndex;
            ViewBag.sec = this.cats.cats[randy.secondIndex].url;
            ViewBag.secondIndex = randy.secondIndex;
            return View();
        }

        public IActionResult Privacy(int catIndex)
        {
            return View();
        }

        public IActionResult Voted(int catIndex)
        {
            this.cats.addVote(catIndex);

            CatRandomizer randy = new CatRandomizer();
            randy.ChooseCandidates(this.cats);
            ViewBag.first = this.cats.cats[randy.firstIndex].url;
            ViewBag.sec = this.cats.cats[randy.secondIndex].url;

            ViewBag.totalVotes = SharedVariables.totalVotes;

            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
