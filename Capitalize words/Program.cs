using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalize_words
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter;
            string text = "How can mirrors be real if our eyes aren't real";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    letter = text[i + 1];
                    letter = Char.ToUpper(letter);
                    text = text.Replace(text[i + 1], letter);
                }
            }
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
