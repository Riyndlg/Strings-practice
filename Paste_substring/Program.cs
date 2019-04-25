using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paste_substring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();
            Console.WriteLine("Enter substring to paste:");
            string sub = Console.ReadLine();
            Console.Write("Enter position (in number) where paste substring: ");
            int position = int.Parse(Console.ReadLine());
            text = text.Insert(position, sub);
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
