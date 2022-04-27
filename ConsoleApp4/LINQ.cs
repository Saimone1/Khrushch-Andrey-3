using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class LINQ
    {
        public void IterateLINQ()
        {
            string[] A = Input();
            int count = 0;
            string correct_word = "";
            Console.WriteLine("Розбиття по елементам");
            foreach (string word in A)
            {
                
                Console.Write(word + "/");  
                if (word.EndsWith("C"))
                {
                    correct_word = word;    
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            try
            {
                if (count == 1)
                    Console.WriteLine(correct_word);
                if (count > 1)
                    Console.WriteLine("ERROR");
                count = 2 / count;
            }
            catch
            {
                Console.WriteLine("Виникло виключення!");
                Console.WriteLine();
            }
        }
        private static string[] Input()
        {
            Console.WriteLine("Введiть строкову послiдовнiсть:");
            string Str = Console.ReadLine();
            string[] A = Str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
      
            return A;
        }
    }
}
