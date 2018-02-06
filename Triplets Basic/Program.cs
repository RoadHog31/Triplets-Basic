using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triplets_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integerArray = { 5, 5, 5, 5, 7, 7, 7, 9, 9, 9, 9, 10, 10, 10, 10, 8, 8, 8 , 9, 9, 9 };

            //int countTriplets = integerArray.GroupBy(e => e).Where(e => e.Count() == 5).Select(e => e.First());

            var triplets = integerArray.GroupBy(x => x).Where(y => y.Count() == 3).Select(z => z.First());
            Console.WriteLine(string.Join(", ", triplets));
            Console.ReadLine();
        }
    }
}
