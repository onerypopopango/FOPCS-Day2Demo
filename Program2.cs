using System;

namespace Day2
{
    class Program2
    {
        public static void Main(string[] args)
        {
            int a = 5;
            int b = 3;

            Console.WriteLine(+a);          //5
            Console.WriteLine(-a);          //-5

            a = 5;                          //reset value of 5
            int c = ++a;                    //increment a and assign result to c
            Console.WriteLine(c);           //6
            Console.WriteLine(a);           //6

            a = 5;                          //reset value of 5
            int d = a++;                    //assign a to d then increment a afterwards
            Console.WriteLine(d);           //5
            Console.WriteLine(a);           //6

            Console.WriteLine("\nJust to keep VS happy, b is {0}", b);

            int e = a++ * ++b / b++;        //please don't do this
            Console.WriteLine(e);

        }
    }
}
