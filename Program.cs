using System;

namespace DaLettera_aDecimale
{
    class Program
    {
        static void Main(string[] args)
        {
            char lettera;
            ushort decimale = 0;
            Console.WriteLine("Inserire la lettera da convertire in ASCII");
            lettera = Convert.ToChar(Console.ReadLine());
            decimale = lettera;
            Console.WriteLine($"La lettera: {lettera} in conversione ASCII è {decimale}");

        }
    }
}
