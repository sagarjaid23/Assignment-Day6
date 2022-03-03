using System;

namespace WeekDay
{
    internal class Program
    { 
        public static int year, y0, month, m0, day, d0, x;
        public static void dayofWeek(int year, int month, int day)
        {
            y0=(year - (14-month))/12;
            x = y0 + (y0 / 4) - (y0 / 100) * (y0 / 400);
            m0=month + 12 * ((14-month)/12)-2;
            switch (month)
            {
                case 1:Console.WriteLine("January"); break;
                case 2:Console.WriteLine("February"); break;
                case 3: Console.WriteLine("March"); break;
                case 4: Console.WriteLine("April"); break;
                case 5: Console.WriteLine("May"); break;
                case 6: Console.WriteLine("June"); break;
                case 7: Console.WriteLine("July"); break;
                case 8: Console.WriteLine("August"); break;
                case 9: Console.WriteLine("Septmber"); break;
                case 10: Console.WriteLine("Octomber"); break;
                case 11: Console.WriteLine("November"); break;
                case 12: Console.WriteLine("December"); break;
                    default: Console.WriteLine("Not Valid"); break;

            }
            Console.WriteLine("Month=" + m0);
            d0 = (day + x + ((31 * m0) / 12) % 7);
            switch (day)
            {
                case 1:Console.WriteLine("Sunday"); break;
                    case 2:Console.WriteLine("Monday"); break;
                case 3: Console.WriteLine("Tuesday"); break;
                    case 4:Console.WriteLine("Wednesday"); break;
                case 5: Console.WriteLine("Thursday"); break;
                    case 6: Console.WriteLine("Friday"); break;
                case 7: Console.WriteLine("Saturday"); break;
                default:
                    Console.WriteLine("Not Valid"); break;

            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Day= " + d0);

        }
    }
}
