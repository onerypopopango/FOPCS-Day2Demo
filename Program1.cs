using System;

namespace Day2
{
    class Program1
    {
        public static void Main(string[] args)
        {
            int a = 5;
            int b = 3;

            Console.WriteLine(5 * 3);           //15

            int c = 5 - 3;
            Console.WriteLine(c);               //2

            Console.WriteLine(a / b);           //1 - integer division
            Console.WriteLine(a % b);           //2 - remainder of 5 divided by 3

            double aa = 5.0;
            double bb = 3.0;

            Console.WriteLine(aa * bb);         //15
            Console.WriteLine(aa - bb);         //2

            Console.WriteLine(aa / bb);         //1.6666667

            //so how does the computer know when to use integer division or normal division?
            //well, if both sides of say a/b are integers, then the computer will use integer division
            //in any other case, it will use normal division

            Console.WriteLine(a / 2);           //2 - interger division
            Console.WriteLine(a / 2.0);         //2.5 - normal division
            Console.WriteLine((double)a / 2);   //2.5 

            Console.WriteLine(aa % bb);         //2.0
        }
    }
}
