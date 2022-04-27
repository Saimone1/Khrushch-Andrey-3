using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Dictionary
    {
        public void IterateDictionary()
        {
            Dictionary<int, string> elements = Input();
            int max = int.MinValue, maxkey = 0;
            int min = int.MaxValue , minkey = 0;
            foreach (var kvp in elements)
            {
                if (max < kvp.Value.Length) { max = kvp.Value.Length; maxkey = kvp.Key; }
                if (min > kvp.Value.Length) { min = kvp.Value.Length; minkey = kvp.Key; }
            }
            Console.WriteLine("KEY OF MAX VALUE = " + maxkey + "; KEY OF MIN VALUE = " + minkey);
            elements.Remove(maxkey);
            elements.Remove(minkey);

            var sortedDict = new SortedDictionary<int, string>(elements);
            foreach (var kvp in sortedDict)
            {
                Console.WriteLine("key: " + kvp.Key);
                Console.WriteLine("values: " + kvp.Value);
                Console.WriteLine();
            }
        }
        private static Dictionary<int, string> Input()
        {
            var elements = new Dictionary<int, string>();
            Console.WriteLine("Введiть кiлькiсть елементiв у словнику:");
            string Str = Console.ReadLine();
            int num;
            int n = 1;
            bool isNum = int.TryParse(Str, out num);
            if (isNum == false || String.IsNullOrEmpty(Str))
            {
                Console.WriteLine("Помилка введення чисел");
            }
            else
            {
                n = Convert.ToInt32(Str);
                if (n < 1)
                {
                    Console.WriteLine("Помилка введення чисел");
                }
                else
                {
                    int[] index = new int[n];
                    string y, Str1;
                    int x;
                    bool repeat;
                    for(int i = 0; i < n; i++)
                    {
                        Console.Write("Ключ:");
                        Str1 = Console.ReadLine();
                        bool isNum1 = int.TryParse(Str1, out num);
                        if (isNum1 == false || String.IsNullOrEmpty(Str1))
                        {
                            Console.WriteLine("Помилка введення чисел");
                        }
                        else
                        {
                            repeat = false;
                            x = Convert.ToInt32(Str1);
                            foreach (int i2 in index)
                            {
                                if (i2 == x) { repeat = true; }
                            }
                            if (repeat) 
                            {
                                Console.WriteLine("Такий ключ вже був використаний");
                            }
                            else
                            {
                                index[i] = x;
                                Console.Write("Значення:");
                                y = Console.ReadLine();
                                AddToDictionary(elements, y, x);
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
            return elements;
        }

        private static void AddToDictionary(Dictionary<int, string> elements, string word, int numkey)
        {
            Element theElement = new Element();
            theElement.Word = word;
            elements.Add(key: numkey, value: theElement.Word);
        }

        public class Element
        {
            public string Word { get; set; }     
        }
    }
}
