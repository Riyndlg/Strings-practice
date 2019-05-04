using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_count
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();
            const string vowel = "aeiou";
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < vowel.Length; j++)
                {
                    if (text[i] == vowel[j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"Vowels: {count}");
            Console.ReadKey();
        }
    }
}
