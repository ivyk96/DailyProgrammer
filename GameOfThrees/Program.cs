using System;

namespace GameOfThrees
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("----------");

            while (input > 1)
            {
                if (input % 3 == 0)
                {
                    Console.WriteLine(input + " 0");
                    input = input / 3;
                }
                else if (input % 3 == 1)
                {
                    Console.WriteLine(input + " -1");
                    input = (input - 1) / 3;
                }
                else
                {
                    Console.WriteLine(input + " +1");
                    input = (input + 1) / 3;
                }
            }
            if (input == 1)
                Console.WriteLine(input);

            Console.ReadKey();
        }
    }
}