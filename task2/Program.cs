using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{

    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("ex 1 **********************");

            string convert = Console.ReadLine();
            double num0 = double.Parse(convert);
            int num1 = int.Parse(convert);
            Console.WriteLine(" int is " + num1);
            Console.WriteLine(" double is " + num0);

            Console.WriteLine("ex 2 **********************");

            string num3 = Console.ReadLine();
            int num4 = int.Parse(num3);
            string num5 = convert.ToString();
            Console.WriteLine(num5);

            Console.WriteLine("ex 3 **********************");

            string str0 = "C# is fun";
            Console.WriteLine(str0.ToUpper());
            Console.WriteLine(str0.ToLower());
            Console.WriteLine(str0.Length);

            Console.WriteLine("ex 4 **********************");

            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            int con0 = str1.Length + str2.Length;

            Console.WriteLine("first name " + str1);
            Console.WriteLine("last  name " + str2);
            Console.WriteLine("total " + con0);

            Console.WriteLine("ex 5 **********************");

            string sum6 = Console.ReadLine();
            string sum7 = Console.ReadLine();
            int num8 = int.Parse(sum6);
            int num9 = int.Parse(sum7);

            if (num8 > num9)
            {
                Console.WriteLine(num9);
            }

            else
            {
                Console.WriteLine(num8);
            }

            Console.WriteLine("ex 6 **********************");

            string sum11 = Console.ReadLine();
            int num12 = int.Parse(sum11);
            double num13 = num12 * 0.6;
            Console.WriteLine(num13);


            Console.WriteLine("ex 7 **********************");


            Console.WriteLine("enter hours");
            string sum13 = Console.ReadLine();
            Console.WriteLine("enter min");
            string num14 = Console.ReadLine();
            int num16 = int.Parse(sum13);
            int num17 = int.Parse(num14);

            int num18 = num16 * 60 + num17;
            Console.WriteLine(num18);


            Console.WriteLine("ex 8 **********************");

            Console.WriteLine("enter hours");
            string sum113 = Console.ReadLine();

            int num116 = int.Parse(sum113);
            double num121 = num116 / 60;
            Console.WriteLine("the hours " + num121);

            Console.WriteLine("ex 9 **********************");



            string sum123 = Console.ReadLine();
            string num134 = Console.ReadLine();
            int num126 = int.Parse(sum123);
            int num127 = int.Parse(num134);
            if (num126 == num127)
            {
                Console.WriteLine("equal");
            }
            if (num126 < num127)
            {
                Console.WriteLine("smaler");
            }
            if (num126 > num127)
            {
                Console.WriteLine("greater");
            }

            Console.WriteLine("ex 10 **********************");

            string sum143 = Console.ReadLine();
            for (int i = sum143.Length - 1; i >= 0; i--)
            {
                Console.Write("reserved number is :" + sum143[i]);

            }

            Console.WriteLine("ex 11 **********************");

            string sum144 = Console.ReadLine();
            int sum1213 = int.Parse(sum144);
            string sum141 = Console.ReadLine();
            int sum121 = int.Parse(sum141);
            if (sum1213 % sum121 != 0)
            {
                Console.WriteLine("not divisble");
            }
            else
            {
                Console.WriteLine("divisble");

            }
            Console.WriteLine("ex 12 **********************");

            string sum164 = Console.ReadLine();
            int sum163 = int.Parse(sum164);
            string sum166 = Console.ReadLine();
            int sum167 = int.Parse(sum166);
            string sum178 = Console.ReadLine();
            int sum179 = int.Parse(sum178);

            if (sum163 > sum167 && sum163 < sum179)
            {

                Console.WriteLine(sum163);

            }
            if (sum163 < sum167 && sum167 < sum179)
            {

                Console.WriteLine(sum167);

            }
            if (sum179 < sum167 && sum163 < sum179)
            {

                Console.WriteLine(sum179);

            }




        }
    }
}
    

