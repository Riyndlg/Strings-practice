using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_to_symbol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();
            StringBuilder temp = new StringBuilder(text);
            char[] arr = text.ToCharArray();
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {

                }
            }
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
