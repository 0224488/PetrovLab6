using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrovLab6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Ввести с клавиатуры предложение. Предложение представляет собой слова, 
            разделенные пробелом. Знаки препинания не используются. 
            Составить программу, определяющую является ли строка палиндромом 
            без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора») 
            
            Кит на море романтик 
            Лёша на полке клопа нашёл 
            И любит Сева вестибюли 
            Удавы рвали лавры в аду
            А щи пища
            */

            Console.WriteLine("Введите предложение без знаков препинания");
            String string1 = Console.ReadLine(); // вводим строку
            string1 = string1.ToLower();         // приводим все символы в строке к прописным
            string string2 = null;               // будущая строка без пробелов
            for (int i = 0; i < string1.Length; i++)
            {
                if (string1[i] != ' ')       // ищем пробелы чтобы исключить
                {
                    string2 += string1[i];   // создаем строку без пробелов
                }
            }
            int ls = string2.Length - 1;     // ввожу дополнительную переменную для цикла
            string1 = "Это предложение является палиндромом";
            for (int j = 0; j < (string2.Length)/2+1; j++) // ограничиваем половиной длины строки +1 символ чтобы не проверять буквы дважды
            {
                // Console.Write(string2[j]); Console.WriteLine(string2[ls]); // просто использовал для визуальной проверки
                if (string2[j] != string2[ls])  // сравниваем символы: первый с последним, второй с предпоследним и т.д
                {
                    string1 = "Это предложение не является палиндромом";
                }
                else
                {
                    ls--;
                }
            }
            Console.WriteLine(string1);
            Console.ReadKey();
        }
    }
}
