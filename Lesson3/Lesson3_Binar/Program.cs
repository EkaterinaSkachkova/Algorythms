using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Binar
{
    class Program
    {
        public static void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }

        public static void Print(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + "  ");
            }
            Console.WriteLine();
        }

        public static void Shake(int[] numbers)
        {
            bool k = false;
            int a = 0;
            int b = numbers.Length - 1;

            while ((a < b) && (k == false))
            {
                k = true;
                bool p = false;

                for (int i = a; i < b; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        Swap(ref numbers[i], ref numbers[i + 1]);
                        k = false;
                        p = true;
                    }
                }
                if (p == false) break;
                else
                {
                    Console.WriteLine("left-right");
                    Print(numbers);
                }

                b--;

                for (int i = b; i > a; i--)
                {
                    if (numbers[i - 1] > numbers[i])
                    {
                        Swap(ref numbers[i - 1], ref numbers[i]);
                        k = false;
                        p = true;
                    }
                }
                if (p == false) break;
                else
                {
                    Console.WriteLine("right-left");
                    Print(numbers);
                }

                a++;
            }
        }

        public static void Binar(int[] numbers, int value)
        {
            int a = 0;
            int b = numbers.Length - 1;
            int c = a + (b - a) / 2;

            while ((a <= b) && (numbers[c] != value))
            {
                if (numbers[c] < value)
                    a = c + 1;
                else
                    b = c - 1;
                c = a + (b - a) / 2;
            }

            if (numbers[c] == value)
                Console.WriteLine("Index of {0} is {1}", value, c);
            else
                Console.WriteLine("{0} is not found", value);
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            Console.WriteLine("Enter 10 numbers");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Print(numbers);
            Shake(numbers);

            Console.WriteLine("Input value for search");
            int value = Convert.ToInt32(Console.ReadLine());

            Binar(numbers, value);

            Console.ReadKey();
        }
    }
}
