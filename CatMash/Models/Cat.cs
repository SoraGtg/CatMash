using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatMash.Models
{
    /* Class : Cat
     * This class is used by the JSON parser to store cat image urls and ids in a list of Cat elements, besides, score of votes is also stored
     * Author : Mokrane Gaci
     */
    public class Cat
    {
        public String url { get; set; }
        public String id { get; set; }
        public int votes { get; set; } = 0;
    }
}
