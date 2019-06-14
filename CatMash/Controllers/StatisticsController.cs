using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CatMash.Models;
using System.Diagnostics;

namespace CatMash.Controllers
{
    public class StatisticsController : Controller
    {
        public IActionResult Statistics()
        {
            StatModel.computeCuteness();
            ViewBag.totalVotes = SharedVariables.totalVotes;
            Cats.cats.Sort();
            ViewBag.cats = Cats.cats;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
