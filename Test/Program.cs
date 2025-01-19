using System;

namespace InputProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************");
            Console.WriteLine("enter string");

            string name = Console.ReadLine();
           
            Console.WriteLine(name);

            Console.Write("******************************");

            int a = 4;
            string b = "aaaa";
            float c = 4.4f;
            double d = 4.4533;
            char j = 'f';
            bool aa = true;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(j);
            Console.WriteLine(aa);



            Console.WriteLine("******************************");


            string[] car = { "audi", "bmw", "toyota" };
            for (int i = 0; i < car.Length; i++)
            {
                Console.WriteLine(car[i]);
            }
            Console.WriteLine("******************************");

            Console.Write("Enter first Name: ");
            string xx = Console.ReadLine();
            Console.Write("Enter last Name: ");
            string cc = Console.ReadLine();
            Console.Write("Enter age: ");
            string vv = Console.ReadLine();

            Console.Write(xx +" ") ;
            Console.Write(cc + " ") ;
            Console.Write(vv + " ") ;


            Console.WriteLine("******************************");

            string[] random = new string[10];
            for (int i = 0; i < random.Length; i++)
            {
                Console.Write("put to array");
                string type =Console.ReadLine();
                random[i] = type;
            }
            foreach (var i in random)
            {
                Console.Write(i+" ");
            }


            Console.WriteLine("******************************");







        }
    }
}