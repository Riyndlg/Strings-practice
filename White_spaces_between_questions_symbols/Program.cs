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
                for (int i = index; i < text.IndexOf('?', index + 1); i++)
			    {
                    if (text[i] == ' ')
                    {
                       text = text.Remove(text.IndexOf(text[i]), 1);
                    }
			    }
                Console.WriteLine(text);
            }
            else Console.WriteLine("Your text does not have enough '?' symbols, try another time");
            Console.ReadKey();
        }
    }
}
