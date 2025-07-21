using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Basic_Student_Grade_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the student grade system");
            Console.WriteLine("here goal is TaskContinuationoptions demonstrate conditions and logic");
            Console.WriteLine("Press any key to continue...");
            Console.WriteLine("Enter marks of the student(0-100)");
            int marks = Convert.ToInt32(Console.ReadLine());
            if (marks <0|| marks >100)
            {
                Console.WriteLine("Invalid marks entered. Please enter a value between 0 and 100.");
            }
            else {

                string result = (marks >= 40) ? "passed" : "failed";
                Console.WriteLine($"The student has {result}with marks:{marks}");
                if (marks >= 90)
                {
                    Console.WriteLine("Grade: A+");

                }
                else if (marks >= 80)
                {
                    Console.WriteLine("Grade: B");

                }
                else if (marks >= 70)
                {

                    Console.WriteLine("Grade: C");
                }
                else if (marks >= 60)
                {
                    Console.WriteLine("Grade: D");
                }
                else if (marks >= 50)
                {
                    Console.WriteLine("Grade: E");
                }
                else
                {
                    Console.WriteLine("Grade: F");
                }


            }
        }
    }
}
