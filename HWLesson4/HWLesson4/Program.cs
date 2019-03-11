using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson4
{
    class Program
    {
        public static int n = 5;
        public static int m = 5;
        public static int[,] desk = new int[n, m];
        //public static int[][] steps = new int[n * m][];
        public static int[][] knight = new int[8][]
        {
            new int [2]{-2,-1},
            new int [2]{-1,-2},
            new int [2]{1,-2},
            new int [2]{2,-1},
            new int [2]{2,1},
            new int [2]{1,2},
            new int [2]{-1,2},
            new int [2]{-2,1}
        };

        public static void Print()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(desk[i, j] + "   ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static int max_step_number = n * m;

        public static bool MoveIsPossible (int x, int y)
        {
            if ((x >= 0) && (x < n) && (y >= 0) && (y < m))
                return true;
            else
                return false;
        }

        public static bool MoveIsAvailable (int x, int y)
        {
            if ((MoveIsPossible(x, y) == true) && (desk[x, y] == 0))
                return true;
            else
                return false;
        }

        public static void NextStep (int c_x, int c_y, int step_number)
        {
            if ((step_number <= max_step_number) && (step_number >= 1))

            {
                int x=0;
                int y=0;
                int n_x;
                int n_y;
                //steps[step_number-1] = new int [2] { c_x, c_y};
                desk[c_x, c_y] = step_number;

                Print();
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();

            
                int p = 8;
                for (int i = 0; i < 8; i++)
                {
                    n_x = c_x + knight[i][0];
                    n_y = c_y + knight[i][1];
                    int ps = 0;

                    if (MoveIsAvailable(n_x, n_y) == true)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (MoveIsAvailable(n_x + knight[j][0], n_y + knight[j][1]) == true)
                                ps++;
                        }

                        if (p > ps)
                        {
                            x = n_x;
                            y = n_y;
                            p = ps;
                        }
                    }
                }

                NextStep(x, y, step_number + 1);


                //switch (i)
                //{
                //    case 0:
                //        n_x = c_x - 2;
                //        n_y = c_y - 1;
                //        if (MoveIsAvailable(n_x, n_y) == true)
                //        {
                //            NextStep(n_x, n_y, step_number + 1);
                //            Print();
                //            Console.ReadKey();
                //        }
                //        break;
                //}




                //desk[c_x, c_y] = 0;
                //step_number--;
                //c_x = steps[step_number][0];
                //c_y = steps[step_number][1];
            }

            //NextStep(steps[step_number][1], steps[step_number][2], step_number);
        }

        static void Main(string[] args)
        {
            int s_x = 2;
            int s_y = 2;
            NextStep(s_x, s_y, 1);
            Console.ReadKey();
        }
    }
}
