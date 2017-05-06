using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Runtime.Remoting.Services;

namespace Module3Assignment
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            menu();
            void menu()
            {
                Console.WriteLine("Which info do you wish to input:");
                Console.WriteLine("Student");
                Console.WriteLine("Teacher");
                Console.WriteLine("Course");
                Console.WriteLine("Program");
                Console.WriteLine("Degree");
                Console.WriteLine("None");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "Student":
                        GetStudentInformation();
                        break;
                    case "Teacher":
                        GetTeacherInformation();
                        break;
                    case "Course":
                        GetCourseInformation();
                        break;
                    case "Program":
                        GetProgramInformation();
                        break;
                    case "Degree":
                        GetDegreeInformation();
                        break;
                    case "None":
                        Console.WriteLine("Exiting application");
                        Environment.Exit(0);
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }

        }

            static void GetStudentInformation()
            {
                Console.WriteLine("Enter the student's first name: ");
                string first = Console.ReadLine();
                Console.WriteLine("Enter the student's last name: ");
                string last = Console.ReadLine();
                Console.WriteLine("Enter the student's birthday: ");
                string birthday = Console.ReadLine();

                PrintStudentDetails(first, last, birthday);
            }

            static void PrintStudentDetails(string first, string last, string birthday)
            {
                Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
            }

            static void GetTeacherInformation()
            {
                Console.WriteLine("Enter the teacher's first name: ");
                string first = Console.ReadLine();
                Console.WriteLine("Enter the teacher's last name: ");
                string last = Console.ReadLine();
                Console.WriteLine("Enter the teachers's subject: ");
                string subject = Console.ReadLine();

                PrintTeacherDetails(first, last, subject);
            }

            static void PrintTeacherDetails(string first, string last, string subject)
            {
                Console.WriteLine("{0} {1} teaches: {2}", first, last, subject);
            }

            static void GetCourseInformation()
            {
                Console.WriteLine("Enter the course name: ");
                string course = Console.ReadLine();
                Console.WriteLine("Enter the course code: ");
                string code = Console.ReadLine();
                Console.WriteLine("Enter the teacher's last name: ");
                string last = Console.ReadLine();

                PrintCourseDetails(course, code, last);
            }

            static void PrintCourseDetails(string course, string code, string last)
            {
                Console.WriteLine("{0} {1} is taught by Prof. {2}", course, code, last);
            }

            static void GetProgramInformation()
            {
                Console.WriteLine("Enter the program name: ");
                string program = Console.ReadLine();
                Console.WriteLine("Enter the program abbreviation: ");
                string abbreviation = Console.ReadLine();
                Console.WriteLine("Enter the number of courses: ");
                string count = Console.ReadLine();

                PrintProgramDetails(program, abbreviation, count);
            }

            static void PrintProgramDetails(string program, string abbreviation, string count)
            {
                Console.WriteLine("{0} ({1}) has {2} courses", program, abbreviation, count);
            }

            static void GetDegreeInformation()
            {
                Console.WriteLine("Enter the degree subject: ");
                string degree = Console.ReadLine();
                Console.WriteLine("Enter the degree level: ");
                string level = Console.ReadLine();
                Console.WriteLine("Enter the degree cost: ");
                string cost = Console.ReadLine();

                PrintDegreeDetails(degree, level, cost);
            }

            static void PrintDegreeDetails(string degree, string level, string cost)
            {
                Console.WriteLine("A {0} degree in {1} costs: {2}", level, degree, cost);
            }
        }
}

