using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction c1 = new Fraction( 19131, 19*19131  );
            Fraction c2 = new Fraction( -1, -1 );

            Console.WriteLine(c1);
            Console.WriteLine(c2);

            Console.WriteLine(c1 + c2);

            Fraction z = new Fraction(1, 2);
            Console.WriteLine($"z = {z}");

            Fraction z1;
            z1 = z - (z * z * z - 1) / (3 * z * z);
            
            Console.WriteLine($"z - (z * z * z - 1) / (3 * z * z) = {z1}");
        }
    }
}
