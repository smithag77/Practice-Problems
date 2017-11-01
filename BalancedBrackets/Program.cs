using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBrackets
{
    class Program
    {
        static bool IsBalanced(string expression)
        {
            Stack<char> bracketStack = new Stack<char>();

            foreach (char c in expression)
            {
                switch (c)
                {
                    case '{':
                        bracketStack.Push('}');
                        break;
                    case '[':
                        bracketStack.Push(']');
                        break;
                    case '(':
                        bracketStack.Push(')');
                        break;
                    default:
                        if (bracketStack.Count == 0 || c != bracketStack.Peek())
                        {
                            return false;
                        }
                        bracketStack.Pop();
                        break;

                }
            }

            return bracketStack.Count == 0;
        }

        static void Main(string[] args)
        {
            string inString;
            Console.Clear();
            Console.Out.Write("Please enter a string containing only { } [ ] ( and )");
            inString = Console.In.ReadLine();

            if (IsBalanced(inString))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            Console.Out.Write("Please press enter to continue...");
            Console.In.ReadLine();
        }
    }
}
