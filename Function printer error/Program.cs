using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_printer_error
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string with letters from a to z without spaces:");
            string text = Console.ReadLine();
            int illegal = 0;
            string ill = "nopuqrstvwxyz";
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < ill.Length; j++)
                {
                    if (text[i] == ill[j])
                    {
                        illegal++;
                    }
                }
            }
            Console.WriteLine(illegal / text.Length);
            Console.ReadKey();
        }
    }
}
