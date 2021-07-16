using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class FIRSTLETTER
    {
        public static int xyz(params int [] arr)
        {
            int z = 0;
            foreach (var i in arr)
                z += i;

             return z;
        }
    }
}
