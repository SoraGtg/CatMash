using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatMash.Models
{
    /*
     * Class : StatModel
     * Holds methods to produce statistical computations (for Statistics view)
     * Author : Mokrane
     */
    public static class StatModel
    {
        public static void ComputeCuteness()
        {
            foreach (var i in Cats.cats)
            {
                i.cuteness = string.Format("{0:N2}", ((double)i.votes / SharedVariables.totalVotes)*100.0 );
            }
        }
    }
}
