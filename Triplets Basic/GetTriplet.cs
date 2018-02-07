using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triplets_Basic
{
    class GetTriplet
    {
        public int FindTriplet(int[] input)
        {       
            //LINQ used to access Array elements, group them by any that appear in 3's and select & return the first element in the sequence. 
            var triplets = input.GroupBy(x => x).Where(y => y.Count() == 3).Select(z => z.First());

            int answer = Convert.ToInt32(triplets.Any());

            return answer;
        }
    }
}
