using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatMash.Models
{
    public static class StatModel
    {
        public static void computeCuteness()
        {
            foreach (var i in Cats.cats)
            {
                i.cuteness = string.Format("{0:N2}", ((double)i.votes / SharedVariables.totalVotes)*100.0 );
            }
        }
    }
}
