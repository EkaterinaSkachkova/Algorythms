using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson6
{
    class Program
    {


        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"tree.txt");

            string str = sr.ReadToEnd();

            Console.WriteLine(str);

            double[] numbers=str.
                Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).
                Select(n=>double.Parse(n)).ToArray();

            Tree<double> tree = new Tree<double>();

            foreach (double d in numbers)
            {
                tree.Add(d);
            }

            tree.Print(tree);
            Console.WriteLine();
            Console.WriteLine(tree.search(tree, 10));
            Console.WriteLine();
            tree.PLR(tree);
            Console.WriteLine();
            tree.LPR(tree);
            Console.WriteLine();
            tree.RPL(tree);
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
