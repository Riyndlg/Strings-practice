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
            /*for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    while (text[i + 1] == ' ')
                    {
                        text = text.Remove(i + 1, 1);
                    }
                }
            }*/
            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 1)
                {
                    words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1, words[i].Length - 1);
                }
                else words[i].ToUpper();
            }
            text = string.Join(" ", words);
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
