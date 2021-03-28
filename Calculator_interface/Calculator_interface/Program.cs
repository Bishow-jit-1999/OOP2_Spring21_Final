using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            CasioBasic B = new CasioBasic();
            B.Sum(2, 5);
            B.Sub(10, 5);
            B.Multiplication(4, 5);
            B.Division(60, 8);

            CasioScientific S = new CasioScientific();
            S.Sin_value(125.35);
            S.Absolute(-100);
            S.X_to_power_y(2,3);
        }
    }
}
