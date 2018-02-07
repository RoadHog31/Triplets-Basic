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
            
            int[] input = { 5, 5, 5, 7, 7, 7, 7, 9, 9, 9, 9, 10, 10, 10, 10, 8, 8, 8, 9, 9, 9, };

            GetTriplet getIt = new GetTriplet();
            Console.WriteLine("Number of triples found are: {0}", getIt.FindTriplet(input));
            Console.ReadLine();
        }

        
            


        
    }
}
