using System;

namespace GoodLine
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = 0;
            string text = Console.ReadLine();
            string []textWrite = text.Split(' ');
            for (int i = 0; i < textWrite.Length; i++)
            {
                    Console.WriteLine(textWrite[i]);
            }
        }
    }
}
