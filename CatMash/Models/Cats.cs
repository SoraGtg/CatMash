using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace CatMash.Models
{
    /* Class : Cats
     * Reads the JSON from L'Atelier's database and stores the urls and ids of the cats
     * Author : Mokrane Gaci
     */
    public class Cats
    {
        public List<Cat> cats { get; set; }

        // This class is only here for the JSON parser to download the JSON file, it shouldn't be used in any other Class
        private class Images
        {
            public List<Cat> images { get; set; }
        }

        public void GatherCats()
        {
            var json = new WebClient().DownloadString("https://latelier.co/data/cats.json");// {'images':{cats}}
            Images catList = new Images();
            catList = JsonConvert.DeserializeObject<Images>(json);
            this.cats = catList.images;
        }

        public void addVote(int catIndex)
        {
            this.cats[catIndex].votes++;
            SharedVariables.totalVotes++;
        }
    }
}
