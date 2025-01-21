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
            private string name;
            private int id;
            private int age;
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
            public int agee
            {
                set {  age = value; }
                get {  return age; }
            }
            public int idd
            {
                set { id = value; }
                get { return id; }
            }
            public string namee
            {
                set { name = value; }
                get { return name; }
            }



        }
        static void Main(string[] args)
        {
            student obj = new student(3,"annas",22);
            obj.getde();
            student obj1 = new student(1, "anas", 4);
            obj1.getde();
            student obj2 = new student(2, "saleh", 6);
            obj2.getde();
        }
    }
}
