using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excessive_white_spaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();
            text = text.Trim();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    while (text[i + 1] == ' ')
                    {
                        text = text.Remove(i + 1, 1);
                    }
                }

            }
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
