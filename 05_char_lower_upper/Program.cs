/*
5. Створити програму, яка вводить з клавіатури символи(посимвольно- Console.Read())
 та перетворює малі букви у великі та навпаки.
 */

using System;

namespace _05_char_lower_upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = ' ';
            Console.Write("Enter some small and big letters, last symbol must be point '.'\n");
            while (c != '.')
            {
                c = Convert.ToChar(Console.Read());
                if (char.IsLower(c))
                    Console.Write(Convert.ToChar(c - 32));
                else
                if (char.IsUpper(c))
                    Console.Write(Convert.ToChar(c + 32));
                else
                    Console.Write(Convert.ToChar(c));
            }

            Console.WriteLine();
        }
    }
}
