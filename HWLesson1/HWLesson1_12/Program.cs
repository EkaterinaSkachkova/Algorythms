using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//12. Написать функцию нахождения максимального из трех чисел.
namespace HWLesson1_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter integer B:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter integer C:");
            int c = Convert.ToInt32(Console.ReadLine());
            if ((a >= b)&&(a > c))
                Console.WriteLine("Max number is:" + a);            
            else
            {
                if (b > c)
                    Console.WriteLine("Max number is:" + b);
                else
                    Console.WriteLine("Max number is:" + c);
            }
            Console.ReadKey();
        }
    }
}

