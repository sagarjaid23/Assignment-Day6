using System;

namespace Decimal_to_binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            string bin = "";

            Console.WriteLine("Enter Any Number");
            n= int.Parse(Console.ReadLine());

            for (; n !=0; n=n/2)
            {
                bin = n % 2 + bin;
            }
            Console.WriteLine("The Binary Format:" +bin);
        }
    }
}
