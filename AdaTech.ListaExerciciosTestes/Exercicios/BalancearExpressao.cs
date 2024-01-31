using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.ListaExerciciosTestes.Exercicios
{
    internal class BalancearExpressao
    {
        public bool ExpressaoBalanceada(string expression)
        {
            var stack = new Stack<char>();

            foreach (char c in expression)
            {
                if ((c == '(' || c == ')') ||
                    (c == '[' || c == ']') ||
                    (c == '{' || c == '}'))
                {
                    if (c == '(' || c == '[' || c == '{')
                    {
                        stack.Push(c);
                    }
                    else if (c == ')' || c == ']' || c == '}')
                    {
                        if (stack.Count == 0) return false;

                        char opening = stack.Pop();
                        if ((c == ')' && opening != '(') ||
                            (c == ']' && opening != '[') ||
                            (c == '}' && opening != '{'))
                        {
                            return false;
                        }
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
