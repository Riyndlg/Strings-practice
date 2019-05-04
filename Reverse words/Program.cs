using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();
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
            string[] words = text.Split(' ');
            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(words[i]);
            }
            Console.ReadKey();
        }
    }
}
