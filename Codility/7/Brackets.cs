using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility._7
{
    public class Brackets
    {
        public int solution(string S)
        {
            return IsBalanced(S) ? 1 : 0;
        }

        private static bool IsBalanced(string expression)
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
    }
}
