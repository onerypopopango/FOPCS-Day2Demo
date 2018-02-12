using System;

namespace Day2
{
    class Program4
    {
        public static void Main(string[] args)
        {
            int a = 5;
            int b = 3;

            Console.WriteLine(a == b);                  //false

            bool c = (a != b);                          //sets c to be true
            Console.WriteLine(c);                       //true

            Console.WriteLine(a < a);                   //false
            Console.WriteLine(a <= a);                  //true

            Console.WriteLine((b > 1) && (a > 10));     //false, && is AND
            Console.WriteLine((b > 1) || (a > 10));     //true, || is OR

            Console.WriteLine(Math.Max(a, b));          //5, gives maximum value
            Console.WriteLine(Math.Min(a, b));          //5, gives minimum value

            Console.WriteLine(Math.Ceiling(2.3));       //3, rounds up
            Console.WriteLine(Math.Round(2.35671));     //2, rounds up to integer
            Console.WriteLine(Math.Round(2.35671, 2));  //2.36, rounds up to 2 decimal places

        }
    }
}
