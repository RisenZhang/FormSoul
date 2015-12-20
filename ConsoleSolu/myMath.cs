using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSolu
{
    class myMath
    {
        public double getAbs(double num)
        {
            if (num < 0)
            {
                num = num * -1;
            }

            return num;
        }

        public double getTriangle (double num1, double num2)
        {
            return num1 * num2 / 2;
        }

        public double getBMI(double hight, double weight)
        {
            return weight / (hight * hight);
        }
            
    }
}
