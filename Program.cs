using System;

namespace LabAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int Remainder;
            Console.WriteLine("A program that returns the remainder of a division operator ");
            Console.WriteLine("Please enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            //use of the modulus operator
           Remainder=  num1 % num2;

           Console.WriteLine("The Remainder of first number divided by the second number is {0} ", Remainder);


        }
    }
}
