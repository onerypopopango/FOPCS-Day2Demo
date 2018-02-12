using System;

namespace Day2
{
    class Program5
    {
        public static void Main()
        {
            Console.Write("Enter a number from 1 - 7: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Mon");
                    break;

                case "2":
                    Console.WriteLine("Tues");
                    break;

                case "3":
                    Console.WriteLine("Wed");
                    break;

                case "4":
                    Console.WriteLine("Thurs");
                    break;

                case "5":
                    Console.WriteLine("Fri");
                    break;

                case "6":
                    Console.WriteLine("Sat");
                    break;

                case "7":
                    Console.WriteLine("Sun");
                    break;

                default:
                    Console.WriteLine("Unknown value!");
                    break;
            }
        }
    }
}
