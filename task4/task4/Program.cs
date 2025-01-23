using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _22_1_2025_task
{
    internal class Program
    {

        class Student
        {

            // private int studentId; // field
            public string Name { get; set; }// property
            public string Email { get; set; }// property
            public int StudentId { get; set; }// property




            private double age;  // field
            public double Age
            {
                get // return data 


                // return backing field 
                { return age; }



                set
                {

                    if (value < MinAge || value > MaxAge) // 11 <18  ||   11 > 40   //  true ||  false  ==> true
                    {
                        age = 18;
                    }
                    else
                    {
                        age = value;
                    }




                }

            }// property   connnect with field 


            public const int MinAge = 18;   // constanct 

            public const int MaxAge = 40;// constanct 


            public Student(string Name, double age, int StudentId)  // parameters 
            {
                //property = paramerter
                this.Name = Name;
                this.age = age;
                this.StudentId = StudentId;
            }

            ~Student()
            {
                Console.WriteLine("finish ");
            }

            public void print()
            {

                Console.WriteLine($" the student name is {Name}  , Email is {Email}  , student id is {StudentId} and age is {age} ");
            }



        }
        static void Main(string[] args)
        {

            Student s = new Student("ahmad", 23.2, 1); //  object  , give initail value to proerty 
            s.Name = "Ahmad";
            s.Age = 41;
            s.StudentId = 1001;

            s.print();


            Student s1 = new Student("ahmad", 23.2, 1);
            s.Name = "Ahmad1";
            s.Age = 22;
            s.StudentId = 1001;

            s.print();

        }
    }
}