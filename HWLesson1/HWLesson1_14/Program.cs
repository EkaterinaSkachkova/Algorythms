using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//14. * Автоморфные числа. Натуральное число называется автоморфным,
//если оно равно последним цифрам своего квадрата. Например, 25^2 = 625.
//Напишите программу, которая вводит натуральное число N и выводит на экран
//все автоморфные числа, не превосходящие N.
namespace HWLesson1_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer N:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i=0; i<n; i++)
            {
                i++;
                int s = i * i;
                int k = 10;
                int a = i / k;
                while (a != 0)
                {
                    k=k*10;
                    a = a / 10;
                }
                if ((s%k)==i)
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
