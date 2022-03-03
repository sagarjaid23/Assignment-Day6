using System;

namespace tempconversion
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            
            {
                double celsius;

                Console.WriteLine("Enter value for celsius:");
                celsius = Convert.ToDouble(Console.ReadLine());
                
                double celToFah = (celsius * 9 / 5) + 32;
               
                Console.WriteLine("celsius to fahrenheit conversion: {0}", celToFah);
               
            }
        }
    }
}
