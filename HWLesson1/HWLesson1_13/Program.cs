using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//13. * Написать функцию, генерирующую случайное число от 1 до 100.
//с использованием стандартной функции rand()
//без использования стандартной функции rand()
namespace HWLesson1_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //без использования стандартной функции rand()
            //int x, a, b, m;
            //m = 100;
            //b = 11;
            //a = 2;
            //x = 1;
            //for (int i=0; i<100; i++)
            //{
            //    x = (a * x + b)%m+1;
            //    Console.WriteLine(x);
            //}

            //с использованием стандартной функции rand()
            Random x = new Random();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(x.Next(1, 101));
            }
                Console.ReadKey();
        }
    }
}
