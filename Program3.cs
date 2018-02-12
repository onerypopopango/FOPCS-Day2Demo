using System;

namespace Day2
{
    class Program3
    {
        public static void Main(string[] args)
        {
            int a = 5;
            int b = 3;

            Console.WriteLine(10 - 5 / a);          //9
            Console.WriteLine(10 - 5 / -a);         //11

            Console.WriteLine(10 - (5 / a));        //9
            Console.WriteLine((10 - 5) / a);        //1

        }
    }
}
