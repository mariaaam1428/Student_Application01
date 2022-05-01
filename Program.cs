/*************************************************************************************************************************************************************/
/* File Name : Student_App.cs                                                                                                                                        */
/* File Info. : This File contains about of code flow                                                                                */
/* Version :V1.0                                                                                                                                            */
/* Data :  december 2020.                                                                                                                                     */
/* Author : Mariam Awad Allah .                                                                                                                              */
/************************************************************************************************************************************************************/

using System;

namespace Student_App
{
    struct Course
    {
        public int Coursecode { get; set; }
        public string Coursename { get; set; }
        public float Coursedegree { get; set; }
        public override string ToString()
        {
            return $"Course: Code= {Coursecode} ,Name= {Coursename} ,Degree= {Coursedegree}";
        }
    }
    struct Student
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        Course[] studentcourses;
        public Student(string Name, string ID, string Gender, Course[] studentcourses)
        {
            this.Name = Name;
            this.ID = ID;
            this.Gender = Gender;
            this.studentcourses = studentcourses;
        }
        public string this[int _code]
        {
            set
            {
                for (int i = 0; i < studentcourses.Length; i++)
                {
                    if (studentcourses[i].Coursecode == _code)
                    {
                        studentcourses[i].Coursename = value;
                    }
                }
            }
            get
            {
                for (int i = 0; i < studentcourses.Length; i++)
                {
                    if (studentcourses[i].Coursecode == _code)
                    {
                        return studentcourses[i].ToString();
                    }
                }
                return "This course in not found";
            }
        }
        public void display(Course[] studentcourses)
        {
            Console.WriteLine("Student name is " + Name);
            Console.WriteLine("Student id is " + ID);
            Console.WriteLine("Student gender is " + Gender);
            foreach (Course p in studentcourses)
            {
                Console.WriteLine(p);
            }
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Course[] studentcourses =
            {
                new Course(){Coursename="Maths ",Coursecode=1000235,Coursedegree=5},
                new Course(){Coursename="physics " ,Coursecode=1001569,Coursedegree=20},
                new Course(){Coursename="chemistry " ,Coursecode=1002059,Coursedegree=18},
                new Course(){Coursename="Arabic ",Coursecode=1000364,Coursedegree=1.5f},
                new Course(){Coursename="English ",Coursecode=1006012,Coursedegree=0.5f}
            };
            Student s = new Student("Mariam Awad Allah", "1000174099", "female", studentcourses);
            s.display(studentcourses);
            Console.WriteLine("==============");
            Console.WriteLine(s[1000235]);
            Console.WriteLine("==============");
            Console.WriteLine(s[10002]);
            Console.WriteLine("==============");
            s[10002] = "Maths 3";
            Console.WriteLine(s[10002]);
            Console.WriteLine("==============");
        }
    }
}