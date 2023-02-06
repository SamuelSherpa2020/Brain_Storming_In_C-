using System;
class AlphabetTriangle
{

    public void PrintAlphabetTriangle()
    {
        string[] words = { "A", "B", "C", "D", "E" };

        int l = words.Length;

        char d = 'y';

        for (int i = 0; i < words.Length; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                if (d == 'y')
                {
                    Console.Write(new string(' ', l));
                }
                Console.Write(words[j]);
                d = 'n';
            }
            for (int k = i; k >= 1; k--)
            {
                Console.Write(words[k - 1]);
            }
            Console.WriteLine();
            l--;
            d = 'y';
        }

    }
}