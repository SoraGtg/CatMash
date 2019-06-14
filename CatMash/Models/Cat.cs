﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatMash.Models
{
    /* Class : Cat
     * This class is used by the JSON parser to store cat image urls and ids in a list of Cat elements, besides, score of votes is also stored
     * Author : Mokrane Gaci
     */
    public class Cat : IComparable<Cat>
    {
        public String url { get; set; }
        public String id { get; set; }
        public long votes { get; set; }
        public String cuteness { get; set; }

        public int CompareTo(Cat other)
        {
            if (this.votes > other.votes) return -1;
            if (this.votes == other.votes) return 0;
            return 1;
        }
    }
}
