using System;

namespace DaLettera_aDecimale
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter;
            ushort decimale = 0;
            Console.WriteLine("Insert the letter:");
            letter = Convert.ToChar(Console.ReadLine());
            decimale = letter;
            Console.WriteLine($"The letter: {letter} converted to ASCII is {decimale}");
            string hexadecimal = decimale.ToString("X");
            Console.WriteLine($"The decimal number converted to hexadecimal is:{hexadecimal}");
            Console.WriteLine("Now try the reconversion.");
            Console.WriteLine("Insert a Decimal Number:");
            ushort decimale2 = Convert.ToUInt16(Console.ReadLine());
            char character = Convert.ToChar(decimale2);
            Console.WriteLine($"The character is {character}");
        }
    }
}
