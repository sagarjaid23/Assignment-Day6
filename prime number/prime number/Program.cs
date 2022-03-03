using System;

namespace prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            

            for (int i = 1; i <= number; i++)
            {
                if(number%i==0)
                {
                    count++;
                }
            }
            if (count==2)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
        }
    }
}
