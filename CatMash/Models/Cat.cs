using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatMash.Models
{
    /* Class : MashModel
     * This class chooses is used by the JSON parser to store cat image urls and total votes in a list of Cat elements
     * Author : Mokrane Gaci
     */
    public class Cat
    {
        public String url { get; set; }
        public String id { get; set; }
        //public int votes { get; set; } = 0;
    }
}
