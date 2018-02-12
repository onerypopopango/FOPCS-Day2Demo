using System;

namespace Day2
{
    class Program6
    {
        public static void Main()
        {
            Console.Write("Enter your result: ");
            string input = Console.ReadLine();
            double result = Double.Parse(input);

            int grade = -1;    //initialising grade to prevent IVE from complaining that it doesn't have any value

            if ((0 <= result) && (result <= 40))
            {
                grade = 1;
            }
            else if ((40 < result) && (result <= 70))
            {
                grade = 2;
            }
            else if ((70 < result) && (result <= 100))
            {
                grade = 3;
            }

            //conditions should be mutually exclusive if possible
            /*
            if ((70 < result) && (result <= 100))
            {
                int grade = 3;
            }
            else if ((40 < result) && (result <= 70))
            {
                grade = 2;
            }
            else if ((0 <= result) && (result <= 40))
            {
                grade = 1;
            }
            */


            if (grade != -1)
            {
                Console.WriteLine("Grade = {0}", grade);
            }
            else
            {
                Console.WriteLine("You entered an invalid result");   
            }
                


        }
    }
}
