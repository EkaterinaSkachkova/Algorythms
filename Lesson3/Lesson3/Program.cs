using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Попробовать оптимизировать пузырьковую сортировку.
//Сравнить количество операций сравнения оптимизированной и неоптимизированной программы.
//Написать функции сортировки, которые возвращают количество операций.

namespace Lesson3
{
    class Program
    {
        public static void Swap (ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }

        public static void Print (int[] numbers)
        {
            for (int i=0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]+"  ");
            }
            Console.WriteLine();
        }

        public static void Sort(int[] numbers)
        {
            int k = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    k++;
                    if (numbers[j] > numbers[j + 1])
                    {
                        Swap(ref numbers[j], ref numbers[j + 1]);
                    }
                }
                Print(numbers);
            }
            Console.WriteLine("Количество сравнений неоптимизированной сортивки: "+k);
        }

        public static void SortOpt (int[] numbers)
        {
            int k = 0;
            for (int i=0; i<numbers.Length; i++)
            {
                bool sw = false;
                for (int j=0; j < numbers.Length - 1; j++)
                {
                    k++;

                    if (numbers[j] > numbers[j + 1])
                    {
                        Swap(ref numbers[j], ref numbers[j + 1]);
                        sw = true;
                    }
                }

                if (sw == false) break;
                else Print(numbers);
            }
            Console.WriteLine("Количество сравнений оптимизированной сортивки: " + k);
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int[] numbers1 = new int[10];

            Console.WriteLine("Enter 10 numbers");

            for (int i=0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                numbers1[i] = numbers[i];
            }

            Print(numbers);
            Sort(numbers);
            Console.WriteLine();
            SortOpt(numbers1);

            Console.ReadKey();
        }
    }
}
