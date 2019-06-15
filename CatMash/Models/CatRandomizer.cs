using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatMash.Models
{
    /*
     * Class : CatRandomizer
     * Provides methods and properties to randomly choose two cat images to be judged
     * Author : Mokrane
     */
    public class CatRandomizer
    {
        private static Random rng = new Random();
        public int firstIndex { get; set; }
        public int secondIndex { get; set; }

        public void ChooseCandidates()
        {
            this.firstIndex = rng.Next()%(Cats.cats.Count);
            do
            {
                this.secondIndex = rng.Next() % (Cats.cats.Count);
            } while (this.secondIndex == this.firstIndex);
        }
    }
}
