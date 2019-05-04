using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_and_shortest_words_in_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();
            int min = int.MaxValue;
            int max = int.MinValue;
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
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length < min)
                {
                    min = words[i].Length;
                }
                if (words[i].Length > max)
                {
                    max = words[i].Length;
                }
            }
            Console.WriteLine($"Length for the longest word in text: {max}");
            Console.WriteLine($"Length for the shortest word in text: {min}");
            Console.ReadKey();
        }
    }
}
