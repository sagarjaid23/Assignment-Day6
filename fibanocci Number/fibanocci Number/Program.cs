using System;

namespace fibanocci_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c;

            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 0; i < 5; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
            
            Console.ReadLine();
                
        }
    }
}
