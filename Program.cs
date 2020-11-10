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

        }
    }
}
