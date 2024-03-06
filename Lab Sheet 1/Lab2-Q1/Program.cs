using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length - ");
            int length = int.Parse(Console.ReadLine());

            Console.Write("Enter the width - ");
            int width = int.Parse(Console.ReadLine());

            int area = Area(length, width);

            Console.WriteLine("Area is " + area);
            Console.ReadLine();

        }
        static int Area(int length, int width)
        {
            return length * width;
        }
    }
}
