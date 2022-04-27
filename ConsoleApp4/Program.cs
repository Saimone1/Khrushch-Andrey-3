using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЗАВДАННЯ 1");
            var numbers = new List<int>();
            Random rnd = new Random();
            Console.WriteLine("Введiть розмiр списку:");
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
                    int[] mas = new int[n];
                    for (int i = 0; i < mas.Length; i++)
                    {
                        mas[i] = rnd.Next(-50, 50);
                        numbers.Add(mas[i]);
                    }
                    Console.WriteLine();
                    foreach (int number in numbers)
                    {
                        Console.Write(number + " ");
                    }
                    Console.WriteLine();

                    Console.WriteLine("Введiть iндекс елементу:");
                    string Str1 = Console.ReadLine();
                    int k;
                    bool isNum1 = int.TryParse(Str1, out num);
                    if (isNum1 == false || String.IsNullOrEmpty(Str1))
                    {
                        Console.WriteLine("Помилка введення чисел");
                    }
                    else
                    {
                        k = Convert.ToInt32(Str1);
                        if (k < 0 || k >= n)
                        {
                            Console.WriteLine("Помилка введення чисел");
                        }
                        else
                        {
                            numbers.RemoveAt(k);

                            Console.WriteLine();
                            foreach (int number in numbers)
                            {
                                Console.Write(number + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }


            Console.WriteLine("ЗАВДАННЯ 2");
            Dictionary dictionary = new Dictionary();
            dictionary.IterateDictionary();


            Console.WriteLine("ЗАВДАННЯ 3");
            LINQ linq = new LINQ();
            linq.IterateLINQ();
        }
    }
}
