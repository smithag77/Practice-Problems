using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalAllEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testing harness. Prompts the user for two strings
            //and invokes the method that compares for permuatations.

            string intString;

            Console.Clear();
            Console.Out.Write("Please enter an list of integers (i.e. '1 3 5 6': ");
            intString = Console.In.ReadLine();

            var splits = intString.Split();
            var myInts = Array.ConvertAll(splits, s => int.Parse(s));

            Console.Out.WriteLine(AddEvenNumbers(myInts));

            Console.Out.Write("Please press enter to continue...");
            Console.In.ReadLine();
        }

        private static long AddEvenNumbers(int[] myInts)
        {
            return myInts.Where(i => i % 2 == 0).Sum(i => (long)i);
        }
    }
}
