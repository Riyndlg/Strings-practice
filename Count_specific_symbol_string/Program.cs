using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_specific_symbol_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();
            Console.Write("Enter symbol to count: ");
            char symbol = Console.ReadKey().KeyChar;
            int count = 0;           
            foreach (char a in text)
            {
                if (symbol == a)
                {
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Symbol {symbol} appears in string {count} times");
            Console.ReadKey();
        }
    }
}
