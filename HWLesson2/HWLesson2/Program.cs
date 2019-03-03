using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//** Исполнитель «Калькулятор» преобразует целое число, записанное на экране
//У исполнителя две команды, каждой присвоен номер: 
//      1. Прибавь 1.
//      2. Умножь на 2.
//Первая команда увеличивает число на экране на 1, вторая увеличивает его в 2 раза.
//Определить, сколько существует программ, которые преобразуют число 3 в число 20:
//     а.С использованием массива.
//     b. * С использованием рекурсии.


namespace HWLesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 1;
            int n = 1; //Количество решений
            int r = 1;
            int[] p = new int[200];
            p[0] = 3;

            for (int i=0; i<r; i++)
            {
                if (p[i] != 0)
                {
                    if (p[i] < 11)
                    {
                        n++;
                        p[i + k] = p[i] + 1;
                        p[i + k + 1] = p[i] * 2;
                        k++;
                    }
                    else
                    {
                        if (p[i] < 20)
                        {
                            p[i + k] = p[i] + 1;
                        }
                        else
                        {
                            k--;
                        }
                    }
                    r++;
                }
            }
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
