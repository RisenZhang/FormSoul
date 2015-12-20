using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProj
{
    public class myClass
    {
        static void Main(string[] args)
        {
        }

        public double myPower(double m, double n)
        {
            double ans = 1;

            for (int i = 0; i < n; i++)
            {
                ans = ans*m;
            }

            return ans;
        }

        public double mySqrt(double n)
        {
            return Math.Sqrt(n);
        }
    }
}
