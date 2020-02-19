using System;

namespace GoodLine3
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = 0;
            string text = Console.ReadLine();
            string[] textWrite = text.Split(' ');
            Array.Sort(textWrite);
            for (int i = 0; i < textWrite.Length; i++)
            {
                for (int j = textWrite.Length - 1; j > i; j--)
                {
                    if (textWrite[i] == textWrite[j])
                    {
                        Array.Clear(textWrite, j, 1);
                        quantity++;
                    }
                }
            }
            for (int i = 0; i < textWrite.Length - 1; i++)
            {
                if (textWrite[i] == "")
                {
                    string trade = textWrite[i];
                    textWrite[i] = textWrite[i + 1];
                    textWrite[i + 1] = trade;
                }
            }
            Array.Resize(ref textWrite, textWrite.Length - quantity);
            for (int i = 0; i < textWrite.Length; i++)
            {
                Console.WriteLine(textWrite[i]);
            }
        }
    }
}
