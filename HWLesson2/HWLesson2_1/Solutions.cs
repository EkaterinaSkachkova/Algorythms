using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson2_1
{
    public class Solutions
    {
        static int k = 0;

        public Solutions(int a)
        {
        }

        public static int F(int a)
        {
            if (a < 6)
            {
                return 1;
            }
            else
            {
                if (a % 2 != 0)
                {
                    k = F(a - 1);
                }
                else
                {
                    k = F(a - 1) + F(a / 2);
                }
                return k;
            }
            
        }
    }
}
