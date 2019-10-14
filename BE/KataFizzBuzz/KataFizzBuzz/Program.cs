using Models;
using System;

namespace KataFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a integer number");
            Console.Clear();

            int number = Convert.ToInt32(Console.ReadLine());
            FizzBuzzGenerator myGenerator = new FizzBuzzGenerator();

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(myGenerator.Generate(i));
            }


        }
    }
}
