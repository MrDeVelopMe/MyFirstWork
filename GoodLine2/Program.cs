using System;

namespace GoodLine2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] textWrite = text.Split(' ');
            Array.Sort(textWrite);
            for (int i = 0; i < textWrite.Length; i++)
            {
                Console.WriteLine(textWrite[i]);
            }
        }
    }
}
