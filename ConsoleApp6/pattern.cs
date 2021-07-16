using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class pattern
    {
        public static void xyz()
        {

            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    if (((i == 1 || i == 6) && (j == 1 || j == 2 || j == 3 || j == 4 || j == 5 || j == 6)) || ((i == 2 || i == 3 || i == 4 || i == 5) && (j == 1) || j == 6)))
                    {
                Console.Write("*");

            }
                    else
            {
                Console.Write("*");
            }
        }
    }
          Console.WriteLine();
                
            }
        }
    }
}
