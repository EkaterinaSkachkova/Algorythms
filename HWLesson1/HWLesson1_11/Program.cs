using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//11. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать среднее
//арифметическое всех положительных четных чисел, оканчивающихся на 8.
namespace HWLesson1_11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int s = 0;
            int i = 0;
            int n=0;
            do
            {
                Console.WriteLine("Enter integer N: ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0 && (n % 10) == 8)
                {
                    s = s + n;
                    i++;
                }
            }
            while (n != 0);
            double a=0;
            if (i != 0)
            {
                a = Convert.ToDouble(s / i);
            }
            Console.WriteLine("Average for numbers is: "+a);
            Console.ReadKey();
        }
    }
}
