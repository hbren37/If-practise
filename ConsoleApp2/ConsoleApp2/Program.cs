using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Please enter a number");

                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter a second number");

                int num2 = int.Parse(Console.ReadLine());

                if (num1 > num2)
                {
                    Console.WriteLine("is larger");
                }
                else if (num1 == num2)
                {

                    Console.WriteLine("Both these numbers are equal");
                }

                {
                    Console.WriteLine("Please type any number between 1 and 10");
                    int userNum = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Can you guess my number between 1-10?");
                }




                {
                    Console.WriteLine("What is your final mark of the year");
                    int gradenum = int.Parse(Console.ReadLine());
                    if (gradenum >= 90)

                    {
                        Console.WriteLine("Final grade A+");
                    }
                    else if (gradenum >= 80)
                    {
                        Console.WriteLine("Final grade A");
                    }
                    else if (gradenum >= 70)
                    {
                        Console.WriteLine("Final grade B+");
                    }
                    else if (gradenum >= 60)
                    {
                        Console.WriteLine("Final grade B");
                    }
                    else if (gradenum >= 50)
                    {
                        Console.WriteLine("Final grade C");
                    }
                    else if (gradenum >= 40)
                    {
                        Console.WriteLine("Final grade D");
                    }
                    else if (gradenum <= 39)
                    { Console.WriteLine("Final grade F"); }

                    Console.ReadKey(); }








                