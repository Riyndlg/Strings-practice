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
            string [] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(' '))
                {

                }
            }
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
