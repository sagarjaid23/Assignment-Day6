using System;

namespace perfect_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0; 
                int n=0;
            Console.WriteLine("Please Enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());
           
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
               
            }
            
            if (sum == n)
            {
                Console.WriteLine("Perfect Number" );
            }
            else
            {
                Console.WriteLine("Not a Perfect Number");
            }
        }
    }
}
