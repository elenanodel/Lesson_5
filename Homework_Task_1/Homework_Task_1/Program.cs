using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduction
            Console.WriteLine("This program will find a sum of numbers, calculates those arithmetical mean and displays is it even or odd.\n");
            Console.WriteLine("First number should be lesser than second!");

            //Declaring variables
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            double sum = 0;
            double average = 0;
            int count = Math.Abs(a - b) + 1;            

            //Finding a sum of numbers and those arithmetical mean (average)
            for (int i = a; i <= b; i++)
            {                
                sum += i;
                average = sum / count;                         
            }            

            Console.WriteLine("\nSum of all numbers: " + sum);
            Console.WriteLine("Arithmetical mean is: " + average + "\n");

            //Converting average to int and checking is it even or odd            
            average = Convert.ToInt32(average);
            double c = average % 2;

            if (c == 0)
            {
                Console.WriteLine("Rounding arithmetical mean: " + average + " - is even.");
            } else
            {
                Console.WriteLine("Rounding arithmetical mean: " + average + " - is odd.");
            }

            Console.ReadLine();
        }
    }
}
