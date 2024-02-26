using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_GaidukovAlexey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите фразу или слово:");

            string greet = Console.ReadLine();
            char[] chars = greet.ToCharArray();
            List<char> doubles = new List<char>();
            
            for (int i = 0; i < chars.Length; i++) 
            {
                for (int j = i+1; j < chars.Length; j++)
                {
                    if ((chars[j] == chars[i]) && (!doubles.Contains(chars[j]))) 
                    {
                        doubles.Add(chars[j]);
                    }
                }
            }

            Console.WriteLine("Повторяющиеся символы:");

            foreach (char c in doubles) 
            {
                Console.Write($"{c} ");
            }

            Console.ReadKey();

        }
    }
}
