using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace CatMash.Models
{
    /* 
     * Class : Cats
     * Reads the JSON from L'Atelier's database and stores the urls and ids of each cat image
     * Author : Mokrane Gaci
     */
    public static class Cats
    {
        public static List<Cat> cats { get; set; }
        public static bool ready { get; set; } = false;

        // Notice : This class is only here to allow the JSON parser to read the remote JSON file, it shouldn't be used in any other Class
        private class Images
        {
            public List<Cat> images { get; set; }
        }

        public static void GatherCats()
        {
            var json = new WebClient().DownloadString("https://latelier.co/data/cats.json");
            Images catList = new Images();
            catList = JsonConvert.DeserializeObject<Images>(json);
            Cats.cats = catList.images;
            Cats.ready = true;
        }

        public static void AddVote(int catIndex)
        {
            Cats.cats[catIndex].votes++;
            SharedVariables.totalVotes++;
        }
    }
}
