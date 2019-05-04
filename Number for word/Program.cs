using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_for_word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();
            Console.WriteLine("Enter number of word (start from 0): ");
            int number = int.Parse(Console.ReadLine());
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
            if (number <= words.Length)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    if (i == number)
                    {
                        Console.WriteLine(words[i].First());
                    }
                }
            }
            else Console.WriteLine("There is no word for this number");
            Console.ReadKey();
        }
    }
}
