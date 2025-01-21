using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_task3_
{
    internal class Program
    {
        public static void odd()
        {
            Console.WriteLine(" odd or even  ");

            string i = Console.ReadLine();
            int i1 = int.Parse(i);
            if (i1 % 2 != 0)
            {
                Console.WriteLine(i1 + "is odd");
            }
            else
            {
                Console.WriteLine(i1 + "is even");

            }
        }

        public static void sort()
        {
            Console.WriteLine("enter array ");

            int[] arr = new int[5];
            for (int j = 0; j < 5; j++)
            {
                string i = Console.ReadLine();
                int i1 = int.Parse(i);
                arr[j] = i1;
            }
            Array.Sort(arr);
            Console.WriteLine(arr[1]);

        }

        public static void fact()
        {
            Console.WriteLine(" factorial number ");

            int d = 1;
            string i = Console.ReadLine();
            int i1 = int.Parse(i);
            for (int j = i1; j >= 1; j--)
            {
                d = d * j;

            }
            Console.WriteLine(d);
        }
        public static void Prime()
        {

            Console.WriteLine("Enter a number to check if prime :");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number <= 1)
            {
                Console.WriteLine(number + " is not a prime number.");
                return;
            }

            bool isPrime = true;

            for (int j = 2; j <= Math.Sqrt(number); j++) 
            {
                if (number % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine(number + " is a prime number.");
            }
            else
            {
                Console.WriteLine(number + " is not a prime number.");
            }
        }
        public static void large()
        {
            Console.WriteLine("second large number in array  ");

            int a = 1;
            int[] arr = { 5, 4, 6, 3, 9 };
            foreach (int i in arr)
            {

                if (a < i)
                {
                   a = i;
                }
            }
            Console.WriteLine(a);


        }
        public static void star()
        {
            Console.WriteLine("q6 answer ");

            int n = 5;
            int num = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num +" ");
                    num++;
                }
                Console.WriteLine();
            }

        }



        class room
        {
            public const string hotelN = "Grand Stay Hotel";
            public int roomN;
            public string roomT;
            public int roomP;
            public string roomB;

        }
        static void Main(string[] args)
        {

            odd();
            sort();
            fact();
            Prime();
            large();
            star();



            room room1 = new room();

            Console.WriteLine("enter room number");
            string r1 = Console.ReadLine();
            int r11 = int.Parse(r1);
            Console.WriteLine("enter room price");
            string r2 = Console.ReadLine();
            int r22 = int.Parse(r2);
            Console.WriteLine("enter room type");
            string r3 = Console.ReadLine();
            Console.WriteLine("enter room avaiblite");
            string r4 = Console.ReadLine();


            room1.roomN = r11;
            room1.roomP = r22;
            room1.roomB = r4;
            room1.roomT = r3;

            Console.WriteLine(room.hotelN);
            Console.WriteLine(room1.roomN);
            Console.WriteLine(room1.roomP);
            Console.WriteLine(room1.roomB);
            Console.WriteLine(room1.roomT);




            





        }
    }
}
