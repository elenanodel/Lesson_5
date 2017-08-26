using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a;

            Console.Write("Enter number of day of week: ");
            a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    {
                        Console.Write("Your day is: Monday");
                        break;
                    }
                case 2:
                    {
                        Console.Write("Your day is: Tuesday");
                        break;
                    }
                case 3:
                    {
                        Console.Write("Your day is: Wednesday");
                        break;
                    }
                case 4:
                    {
                        Console.Write("Your day is: Thursday");
                        break;
                    }
                case 5:
                    {
                        Console.Write("Your day is: Friday");
                        break;
                    }
                case 6:
                    {
                        Console.Write("Your day is: Saturday");
                        break;
                    }
                case 7:
                    {
                        Console.Write("Your day is: Sunday");
                        break;
                    }
                default:
                    {
                        Console.Write("Numbers should be from 1 to 7");
                        break;
                    }
            }*/

            /*const string correctpassword = "qwerty";
            string userpassword;
            bool a = true;
            int counter = 0;

            do
            {
                Console.Write("Enter your password: ");
                userpassword = Console.ReadLine();
                
                if (correctpassword.Equals(userpassword)){
                    a = false;
                    Console.WriteLine("Correct password");
                }
                else
                {                    
                    Console.WriteLine("Incorrect password!\n");                    
                    counter++;
                    if(counter == 3)
                    {
                        Console.WriteLine("You can't enter password anymore!");
                        break;
                    }
                }
            }
            while (a);*/


            /*int n;

            Console.Write("Enter your number: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = n; i > 0; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/

            //после каждого десятка перевод на новую строку
            /*int a = 255;
            for (int i = 0; i <=a; i++)
            {
                Console.Write(i + " ");
                if (i % 10 == 0)
                {
                    Console.WriteLine();
                }
            }*/

            Console.Write("Enter size of square: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (i == 0 || i == (num - 1))
                    {
                        Console.Write("*");
                    }
                    else if (j == 0 || j == (num - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
