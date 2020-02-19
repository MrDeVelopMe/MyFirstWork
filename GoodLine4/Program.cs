using System;

namespace GoodLine4
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = 0;
            string text = Console.ReadLine();
            string[] textWrite = text.Split(' ');
            int[] quantityWord = new int[textWrite.Length];
            for (int i = 0; i < quantityWord.Length; i++)
            {
                quantityWord[i]++;
            }
            Array.Sort(textWrite);
            for (int i = 0; i < textWrite.Length; i++)
            {
                for (int j = textWrite.Length - 1; j > i; j--)
                {
                    if (textWrite[i] == textWrite[j])
                    {
                        Array.Clear(textWrite, j, 1);
                        quantity++;
                        quantityWord[i]++;
                    }
                }
            }
            for (int i = 0; i < textWrite.Length - 1; i++)
            {
                if (textWrite[i] == "")
                {
                    int tradeint = quantityWord[i];
                    quantityWord[i] = quantityWord[i + 1];
                    quantityWord[i + 1] = tradeint;
                    string trade = textWrite[i];
                    textWrite[i] = textWrite[i + 1];
                    textWrite[i + 1] = trade;
                }
            }
            Array.Resize(ref textWrite, textWrite.Length - quantity);
            Array.Resize(ref quantityWord, quantityWord.Length - quantity);
            for (int i = 0; i < textWrite.Length; i++)
            {
                Console.WriteLine(textWrite[i] + " " + quantityWord[i]);
            }
        }
    }
}
