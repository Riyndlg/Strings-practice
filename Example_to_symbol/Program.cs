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
            int count;
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();
            string result = "";
            foreach (char c in text) 
            {
                count = 0;
                foreach (char c2 in result) //проверка, что символ не является дубликатом
                {
                    if (c2 == c)
                    {
                        count++;
                    }
                }
                if (count < 1) //проверка, что символ не повторялся еще в строке, вместо 1 может быть другое допустимое число дубликатов символа в строке
                 {
                    result = result + c;
                 }       
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
