using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/* Class : CatRandomizer
 * Takes a list of cats and randomly chooses two candidates to be judged
 * Author : Mokrane Gaci
 */
namespace CatMash.Models
{
    public class CatRandomizer
    {
        private static Random rng = new Random();
        public int firstIndex { get; set; }
        public int secondIndex { get; set; }

        public void ChooseCandidates(Cats cats)
        {
            this.firstIndex = rng.Next()%(cats.cats.Count);
            do
            {
                this.secondIndex = rng.Next() % (cats.cats.Count);
            } while (this.secondIndex == this.firstIndex);
        }
    }
}
