using System;

namespace H03_Oef09_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Number ?");
            number = Convert.ToInt16(Console.ReadLine());
            //
            int square;
            square = number * number;
            //
            Console.WriteLine("Square of " + number + " is " + square + ".");
            Console.ReadLine();
        }
    }
}
