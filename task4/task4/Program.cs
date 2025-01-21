using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Task4.Program;

namespace Task4
{
    internal class Program
    {
        public class student
        {
            public string name { get; set; }
            public int id { get; set; }
            private int age { get; set; }
            public string email { get; set; }

            public const int maxage = 40;
            public const int minage = 18;

            public int _age
            {
                set
                {
                    if (age<minage )
                    {
                        age=minage;
                    }if (age>maxage)
                    { age=maxage; }
                }
                get
                {
                    return age;
                }
            }
            public void getde()
            {
                Console.WriteLine($"Student Name: {name} Age: {age} id: {id}");

            }
            public student()
            {
                name = "";
                age = 2;
                id = 1;
            }
            public student(int id, string name, int age)
            {
                this.id = id;
                this.name = name;
                this.age = age;

            }

            ~student()
            {
                Console.WriteLine("delet");
            }




        }
        static void Main(string[] args)
        {
            student obj = new student();
            obj.name = "anas";
            obj.id = 1;
            obj._age= 1;
            obj.getde();
            student obj1 = new student(1, "anas", 4);
            obj1.getde();
            student obj2 = new student(2, "saleh", 6);
            obj2.getde();
        }
    }
}
