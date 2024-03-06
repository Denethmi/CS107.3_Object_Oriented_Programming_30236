using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 10; i++)
            {

                Console.Write("Enter a number : ");
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.Write("It's a even number");
                    Console.ReadLine();
                }
                else
                {
                    Console.Write("It's a odd number");
                    Console.ReadLine();
                }

            }


        }
    }
    }
}
