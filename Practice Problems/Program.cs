using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems
{
    class Program
    {
        static private bool IsPermutation(string myString1, string myString2)
        {
            //If the strings are different lengths, they are not
            //permutations.
            if (myString1.Length != myString2.Length) return false;

            //Create an array to count the number of each specific
            //character in the strings.
            int[] characterCount = new int[256];
            int charIndex;

            //Populate the array with default value 0.
            for (int index = 0; index < 256; index++)
            {
                characterCount[index] = 0;
            }

            //Count the number of each character in the first
            //string. Add the count to the array.
            foreach (char myChar in myString1.ToCharArray())
            {
                charIndex = (int)myChar;
                characterCount[charIndex]++;
            }

            //Count the number of each character in the second
            //string. Subtract the count from the array.
            foreach (char myChar in myString2.ToCharArray())
            {
                charIndex = (int)myChar;
                characterCount[charIndex]--;
            }

            return characterCount.All(c => c == 0);
            ////If the strings are permutations, then each character
            ////would be added to our character count array and then
            ////subtracted. If all values in this array are not 0
            ////then the strings are not permutations of each other.
            //for (int index = 0; index < 256; index++)
            //{
            //    if (characterCount[index] != 0) return false;
            //}

            ////The strings are permutations of each other.
            //return true;
        }

        static void Main(string[] args)
        {
            //Testing harness. Prompts the user for two strings
            //and invokes the method that compares for permuatations.

            string myString1, myString2;

            Console.Clear();
            Console.Out.Write("Please enter any string: ");
            myString1 = Console.In.ReadLine();

            Console.Out.Write("Please enter another string: ");
            myString2 = Console.In.ReadLine();

            if (IsPermutation(myString1, myString2)) Console.Out.WriteLine("These strings are permutations.\n");
            else Console.Out.WriteLine("These strings are not permutations.\n");

            Console.Out.Write("Please press enter to continue...");
            Console.In.ReadLine();
        }
    }
}
