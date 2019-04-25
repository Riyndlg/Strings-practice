using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace White_spaces_between_questions_symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text (should contain at least 2 '?' symbols):");
            string text = Console.ReadLine();
            int count = 0;
            int index = text.IndexOf('?');
            foreach (var c in text)
            {
                if (c == '?')
                {
                    count++;
                }
            }
            if (count >= 2)
            {
                count = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == '?')
                    {
                        count++;
                    }
                    while (count == 1)
                    {
                        for (int j = index; j < text.Length; j++)
                        {
                            if (text[j] == ' ')
                            {
                                text = text.Remove(text.IndexOf(text[j]), 1);
                            }
                        }
                    }
                }
                Console.WriteLine(text);
            }
            else Console.WriteLine("Your text does not have enough '?' symbols, try another time");
            Console.ReadKey();
        }
    }
}
