using System;

namespace Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void countCurrency(int amount)
            {

                int[] notes = new int[] { 1000, 500, 100, 50, 10, 5, 2, 1 };
                int[] Counter = new int[8];

            
                for (int i = 0; i < 8; i++)
            {
                if (amount >= notes[i])
                {
                    Counter[i] = amount / notes[i];
                    amount = amount - Counter[i] * notes[i];
                }
            }

            Console.WriteLine("Currency Count ->");
            for (int i = 0; i < 8; i++)
            {
                if (Counter[i] != 0)
                {
                    Console.WriteLine(notes[i] + " : "
                        + Counter[i]);
                }
            }
        }

        {
                Console.WriteLine("Please Enter the number:");
                int amount = Convert.ToInt32(Console.ReadLine());
                countCurrency(amount);
                

            }
            
        }
    }
}
