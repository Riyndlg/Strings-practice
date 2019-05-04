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
            int count = 0;
            text = text.Trim();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    count++;
                }

            }
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
