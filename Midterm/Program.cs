using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {
        public static myProj.myClass myLib = new myProj.myClass();

        static void Main(string[] args)
        {
            Fuct();
        }

        static void Fuct()
        {
            Console.WriteLine("1.Q1 輸入N,列出 小於 N 的所有 3,5,7三數的公倍數(Common Multiple)");
            Console.WriteLine("2.Q2 輸入一數字, 將各個數字翻譯成中文輸出");
            Console.WriteLine("3.Q3 找Long的最小數");
            Console.WriteLine("4.Q4 計算f(x)=x2+2x+100√x");
            Console.WriteLine("5.Q5 計算舞會參加費總額");
            Console.Write("輸入選擇:");
            string opt;
            opt = Console.ReadLine();

            switch (opt)
            {
                case "1":
                    Q1();
                    break;
                case "2":
                    Q2();
                    break;
                case "3":
                    Q3();
                    break;
                case "4":
                    Q4();
                    break;
                case "5":
                    Q5();
                    break;
                default:
                    Console.WriteLine("無此選項");
                    break;
            }
        }

        static void Q1()
        {
            string input;

            Console.Write("Please input N:");
            input = Console.ReadLine();

            int remainder = judgeN(input);

            int count = 1;

            while (count < remainder)
            {
                if (count % 3 == 0 && count % 5 == 0 && count % 7 == 0)
                    Console.WriteLine("-->{0}", count);
                count++;
            }
            Fuct();
        }

        static void Q2()
        {
            string trans = "";
            string input = "";
            Console.Write("Please enter string:");
            input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                switch (input.Substring(i, 1))
                {
                    case "1":
                        trans = trans + "壹";
                        break;
                    case "2":
                        trans = trans + "貳";
                        break;
                    case "3":
                        trans = trans + "叁";
                        break;
                    case "4":
                        trans = trans + "肆";
                        break;
                    case "5":
                        trans = trans + "伍";
                        break;
                    case "6":
                        trans = trans + "陸";
                        break;
                    case "7":
                        trans = trans + "柒";
                        break;
                    case "8":
                        trans = trans + "捌";
                        break;
                    case "9":
                        trans = trans + "玖";
                        break;
                    case "0":
                        trans = trans + "零";
                        break;
                }
            }
            Console.WriteLine("Ans:{0}", trans);
            Fuct();

        }

        static void Q3()
        {
            short min = 0;

            while (true)
            {
                try
                {
                    checked
                    {
                        min = (short)(min - 1);
                        Console.WriteLine("-->{0}", min);
                    }
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Overflow!數學運算導致溢位。");
                    break;
                }
            }
            Fuct();
        }

        static void Q4()
        {
            string input = "";
            double ans = 0.0;

            Console.Write("Please input x:");
            input = Console.ReadLine();

            int x = judgeN(input);

            ans = myLib.myPower(x, 2) + 2 * x + 100 * myLib.mySqrt(x);
            Console.WriteLine("-->{0}", ans);

            Fuct();
        }

        static void Q5()
        {
            string input_vam = "";
            string input = "";
            int height = 0;
            int sum = 0;

            while (input_vam != "E")
            {
                Console.Write("Please input Sex:M / F (E for exit) ");
                input_vam = Console.ReadLine().ToUpper();

                if (input_vam == "M")
                {
                    Console.Write("input Height:");
                    input = Console.ReadLine();
                    height = judgeN(input);

                    if (height < 160)
                    {
                        sum = sum + 200;
                    }
                    else if (height < 170 && height >= 160)
                    {
                        sum = sum + 100;
                    }
                    else if (height < 180 && height >= 170)
                    {
                        sum = sum + 50;
                    }
                    else if (height < 190 && height >= 180)
                    {
                        sum = sum + 100;
                    }
                    else if (height >= 190)
                    {
                        sum = sum + 200;
                    }
                    Console.WriteLine("--------------");
                }
                if (input_vam == "F")
                {
                    Console.Write("input Height:");
                    input = Console.ReadLine();
                    height = judgeN(input);

                    if (height < 160)
                    {
                        sum = sum + 300;
                    }
                    else if (height < 170 && height >= 160)
                    {
                        sum = sum + 200;
                    }
                    else if (height < 180 && height >= 170)
                    {
                        sum = sum + 100;
                    }
                    else if (height < 190 && height >= 180)
                    {
                        sum = sum + 200;
                    }
                    else if (height >= 190)
                    {
                        sum = sum + 300;
                    }
                    Console.WriteLine("--------------");
                }
                if (input_vam == "E")
                {
                    break;
                }
            }
            Console.Write("參加費總額:{0}", sum);
            Fuct();
        }

        static int judgeN(string num)
        {
            int N = 0;

            try
            {
                N = int.Parse(num);
            }
            catch (OverflowException oex)
            {
                Console.WriteLine("請勿輸入超過2,147,483,647" + oex);
                Fuct();
            }
            catch (FormatException fex)
            {
                try // 判斷是字串還是小數
                {
                    double checkmutitable = double.Parse(num);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("請勿輸入字串" + ex);
                    Fuct();
                }
                Console.WriteLine("請勿輸入小數" + fex);
                Fuct();
            }

            if (N < 0)
            {
                Console.WriteLine("請勿輸入負整數");
                Fuct();
            }

            return N;
        }
    }
}
