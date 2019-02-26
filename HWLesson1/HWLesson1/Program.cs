using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//10. Дано целое число N (> 0). С помощью операций деления нацело и взятия остатка
//от деления определить, имеются ли в записи числа N нечетные цифры. Если имеются,
//то вывести True, если нет — вывести False.
namespace HWLesson1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter positive integer number N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int d=0;
            while (n != 0)
            {
                d = n % 10;
                if ((d % 2) != 0)
                {
                    Console.WriteLine("TRUE");
                    break;
                }
                else
                    d = 1;
                n = n / 10;
            }
            if (d==1)
                Console.WriteLine("FALSE");
            Console.ReadKey();
        }
    }
}
