using System;

namespace Calculate_Lektion0_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Test Trine");
            Calculate calculate = new Calculate();
            Console.WriteLine("Emma is here");

            double add = calculate.Add(3, 6);
            if (add == 9)
            {
                Console.WriteLine("Der er regnet rigtig");
            }
            else
            {
                Console.WriteLine("Der er ikke regnet rigtig");
            }

            calculate.Multiply(4, 5);
            calculate.Subtract(5, 1);

        }
    }
}
