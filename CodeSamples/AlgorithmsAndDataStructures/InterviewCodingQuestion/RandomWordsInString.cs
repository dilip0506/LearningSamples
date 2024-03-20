using System;
using System.Collections.Generic;
using System.Text;

namespace RandomWordsInString
{
    class RoundThree
    {
        private static Stack<int> OneStack = new Stack<int>();
        static StringBuilder Input = new StringBuilder();
        static string ReturnWords(string subString)
        {
            string[] Words = subString.Split('|');
            return Words[new Random().Next(0, Words.Length)];
        }

        static string FormString(StringBuilder input)
        {        
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '{')
                {
                    OneStack.Push(i);
                }
                else if (input[i] == '}')
                {
                    do
                    {
                        int val = OneStack.Pop();
                        int index = val + 1;
                        string substr = ReturnWords(input.ToString(index, i - index));
                        if (OneStack.Count != 0 && input[OneStack.Peek()] == '{')
                        {
                            input.Remove(val - 1, i - val + 2);
                            input.Insert(val - 1, substr);
                            input.Insert(val + substr.Length, '{');
                        }
                        else
                        {
                            input.Remove(val, i - val + 1);
                            input.Insert(val, substr);
                            i = val + substr.Length;
                        }

                        if (OneStack.Count > 0)
                            OneStack.Pop();
                        i = val + substr.Length-1;
                    } while (OneStack.Count > 0);
                }
               
            }
            return Input.ToString();
        }

        static void Main(string[] args)
        {
            string input = "{I am|I'm} {working on|starting} this {online |}interview. I hope Cortx thinks I am {{very|extremely} qualified|great|awesome}{!|.}";
            Console.WriteLine(FormString(Input.Append(input)));
            Console.Read();
        }
    }
}
