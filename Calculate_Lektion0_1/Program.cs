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

            double add = calculate.Add(3, 6);
            if (add == 9)
            {
                Console.WriteLine("Der er regnet rigtig");
            }
            else
            {
                Console.WriteLine("Der er ikke regnet rigtig");
            }



        }
    }
}
