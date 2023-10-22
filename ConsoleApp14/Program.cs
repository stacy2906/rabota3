using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1.Найти самое длинное слово из пяти введенных с клавиатуры.

            //Console.WriteLine("Введите пять слов через пробел:");
            //string input = Console.ReadLine();
            //string[] words = input.Split(' ');

            //string longestWord = "";
            //foreach (string word in words)
            //{
            //    if (word.Length > longestWord.Length)
            //    {
            //        longestWord = word;
            //    }
            //}

            //Console.WriteLine("Самое длинное слово: " + longestWord);

            //Задача 2.Составьте программу, удаляющую букву «е» («Е») из предложения.

            //Console.WriteLine("Введите предложение:");
            //string input = Console.ReadLine();

            //string result = input.Replace("е", "").Replace("Е", "");

            //Console.WriteLine("Предложение без букв 'е' и 'Е': " + result);

            //Задача 3.Составьте программу вычисления количества букв «а» («А») в предложении.

            //Console.WriteLine("Введите предложение:");
            //string input = Console.ReadLine();

            //int count = 0;
            //foreach (char letter in input)
            //{
            //    if (letter == 'а' || letter == 'А')
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine("Количество букв 'а' и 'А' в предложении: " + count);

            //Задача 4.Составьте программу, определяющую длину первого слова в предложении.

            //Console.WriteLine("Введите предложение:");
            //string input = Console.ReadLine();

            //string[] words = input.Split(' ');
            //if (words.Length > 0)
            //{
            //    int length = words[0].Length;
            //    Console.WriteLine("Длина первого слова: " + length);
            //}
            //else
            //{
            //    Console.WriteLine("Предложение не содержит слов.");
            //}

            //Задача 5.Составьте программу, определяющую длину последнего слова в предложении.

            //Console.WriteLine("Введите предложение:");
            //string input = Console.ReadLine();

            //string[] words = input.Split(' ');
            //if (words.Length > 0)
            //{
            //    int length = words[words.Length - 1].Length;
            //    Console.WriteLine("Длина последнего слова: " + length);
            //}
            //else
            //{
            //    Console.WriteLine("Предложение не содержит слов.");
            //}

            //Задача 6.Составьте программу, заменяющую букву «а» («А») на «о» («О») в предложении.

            //Console.WriteLine("Введите предложение:");
            //string input = Console.ReadLine();

            //string result = input.Replace("а", "о").Replace("А", "О");

            //Console.WriteLine("Предложение после замены: " + result);

            //Задача 7.Написать программу для получения реверсированной строки.

            //Console.WriteLine("Введите строку:");
            //string input = Console.ReadLine();

            //char[] charArray = input.ToCharArray();
            //Array.Reverse(charArray);

            //string reversedString = new string(charArray);

            //Console.WriteLine("Реверсированная строка: " + reversedString);
        }
    }
}
