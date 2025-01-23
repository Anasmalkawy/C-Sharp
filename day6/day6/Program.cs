using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    internal class Program
    {
        public class overloading
        {
            public void dd(int x, int y)
            {
                Console.WriteLine(x + "," + y);
            }
            public void dd(string x, string y)
            {
                Console.WriteLine(x + "," + y);
            }
            public void dd(string x)
            {
                Console.WriteLine(x);
            }
        }
        static void Main(string[] args)
        {
            overloading print = new overloading();
            print.dd("moghammed ", "sofyan ");
            print.dd(1, 2);
            print.dd("amal");
            
            



        }
    }
}
