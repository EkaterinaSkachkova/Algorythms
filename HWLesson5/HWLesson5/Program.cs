using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson5
{
    class Program
    {
        public static void Ar(char[]a,char[]b,int c)
        {
            if (c != 0)
            {
                int j = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] != ' ')
                    {
                        b[j] = a[i];
                        j++;
                    }
                }
            }

            Stack<char> stack = new Stack<char>();

            char[] result = new char[b.Length];

            for (int i = 0; i < b.Length; i++)
            {
                if (Char.IsDigit(b[i]))
                {
                    result[i] = b[i];
                }

                if ((b[i] == '+') || (b[i] == '-') || (b[i] == '*') || (b[i] == '/') ||
                (b[i] == '^'))
                {
                    stack.Push(b[i]);
                }

                if ((b[i] == ')') || (b[i] == ']') || (b[i] == '}') || (b[i] == '|'))
                {
                    result[i] = stack.Pop();
                }
            }

            Console.WriteLine(result);
        }


        public static void Convertion(char[] str)
        {
            bool flag = false;
            int k = 0;

            for (int i=str.Length-1; i>=0; i--)
            {
                if ((str[i]==')')||(str[i] == ']')||(str[i] == '}')||(str[i] == '|'))
                {
                    for (int j=0; j < str.Length; j++)
                    {
                        if ((str[j] == '(') || (str[j] == '[') || (str[j] == '{') || (str[j] == '|'))
                        {
                            if ((i > j) && ((str[i] == ')')&&(str[j] == '(')||
                                (str[i] == ']') && (str[j] == '[')|| (str[i] == '}') && (str[j] == '{')||
                                (str[i] == '|') && (str[j] == '|')))
                            {
                                str[j] = ' ';
                                k++;
                                break;
                            }
                            else
                            {
                                flag = true;
                                Console.WriteLine("Expression is not correct");
                                break;
                            }
                        }
                    }
                }
                if (flag)
                    break;
            }

            if (!flag)
                Console.WriteLine(str);

            if ((str[str.Length - 1] =='+')||(str[str.Length - 1] == '-')||
                (str[str.Length - 1] == '*')||(str[str.Length - 1] == '/')||
                (str[str.Length - 1] == '^'))
                Console.WriteLine("Expression is not correct");


            if (Char.IsDigit(str[str.Length - 1]))
            {
                char[] newstr = new char[str.Length - k + 1];
                Ar(str, newstr, k);
                newstr[newstr.Length - 1] = ')';
            }
            else
            {
                char[] newstr = new char[str.Length - k];
                Ar(str, newstr, k);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter new expression");
            char[] str = Console.ReadLine().ToArray<char>();
            Convertion(str);
            Console.ReadKey();
        }
    }
}
