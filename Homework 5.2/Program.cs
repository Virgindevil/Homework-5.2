using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Введите предложение:");
            ReverseWords(Console.ReadLine());
        }

        public static void ReverseWords(string check)
        {
            string[] sentence = TakeWords(check);
            Console.Write($"\n");
            Console.WriteLine("Ваше предложение наоборот:");
            Array.Reverse(sentence);
            foreach (string word in sentence)
            {
                Console.Write($"{word} ");
            }
            Console.ReadKey();
        }
        public static string[] TakeWords(string words)
        {
            string[] sentence = words.Split(' ');
            return sentence;
        }
    }
}
