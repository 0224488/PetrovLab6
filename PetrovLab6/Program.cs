using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrovLab6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ввести с клавиатуры предложение. 
            * Предложение представляет собой слова, разделенные пробелом. 
            * Знаки препинания не используются. 
            * Найти самое длинное слово в строке.*/

            Console.WriteLine("Введите предложение без знаков препинания");
            String string1 = Console.ReadLine() + " "; // Пробел будет как флаг окончания слова, в т.ч последнего
            String sim = "символов";
            int word = 0; // промежуточная переменная для подсчета количества символов в слове
            int maxWord = 0; // Длина максимального слова
            for (int i = 0; i < string1.Length; i++)
            {
                if (string1[i] == ' ')
                {
                    if (maxWord < word)
                    {
                        maxWord = word;
                    }
                    word = 0;
                }
                else
                {
                    word++;
                }
            }
            if (maxWord < 5)
            {
                sim = "символа";
            }
            if (maxWord == 1)
            {
                sim = "символ";
            }
            Console.WriteLine("Самое длинное слово имеет {0} {1}", maxWord, sim);
            Console.ReadKey();
        }
    }
}
