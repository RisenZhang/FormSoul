using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSolu
{
    class myClass
    {
        public double bmi(double height, double weight)//計算bmi
        {   
            return weight / (height * height);
        } 
        public double area(int radius)//計算圓形(circle)面積
        {
            return radius * radius * Math.PI;
        }
        public double area(int width, int height)//計算矩形(rectangle)面積
        {
            return width * height;
        }
        public double average(int n1, int n2, int n3) //計算3數的平均數
        {
            return (n1+n2+n3)/3;
        }
        public void printTriange(string inStr)
        {
            for (int i = 1; i <= inStr.Length; i++)
            {
                Console.WriteLine(inStr.Substring(0, i));
            }
            
        }
    }
}
