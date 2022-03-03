using System;

namespace reverse_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            int rem;

            while (num != 0)
            {
                rem = num % 10;
                result = result*10 + rem;
                num=num / 10;
            }
            Console.WriteLine("Reverse Number is:" +result);

        }
    }
}
