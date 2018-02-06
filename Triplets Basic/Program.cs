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
            //Note: You could also allow the user to input the array list in the console window and then compute any triplets as per below. 

            //Array object created. 

            int[] integerArray = { 5, 5, 5, 5, 7, 7, 7, 9, 9, 9, 9, 10, 10, 10, 10, 8, 8, 8, 9, 9, 9, };

            //LINQ used to access Array elements, group them by any that appear in 3's and select & return the first element in the sequence. 
            var triplets = integerArray.GroupBy(x => x).Where(y => y.Count() == 3).Select(z => z.First());
            //This is then wrote out in the console window with commas between. 
            Console.WriteLine(string.Join(", ", triplets));
            //The number of triplets are counted and output to the console window. 
            Console.WriteLine("Number of triplets in the Array = {0}", triplets.Count());

            Console.ReadLine();
        }

        
            


        
    }
}
