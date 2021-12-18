using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_11
{
    public class Class1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="rez1"></param>
        /// <param name="rez2"></param>
        public static void Proizv(int n, out string rez1, out int rez2)
        {

            int rezult = 1;
            rez1 = "";
            rez2 = 0;
            Random rnd = new Random();
            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    int x = rnd.Next(n);
                    rez1 = rez1 + x.ToString() + ";"; 
                    rezult = rezult * x;
                }
                rez2 = rezult; 
            }
        }
    }
}
