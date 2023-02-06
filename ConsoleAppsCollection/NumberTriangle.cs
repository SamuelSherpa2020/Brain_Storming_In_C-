using System;
class NumberTriangle
{
    public void PrintNumberTriangle()
    {
        Console.Write("Enter the range: ");

        int num = int.Parse(Console.ReadLine());
        int space = num;
        for (int i = 1; i <= num; i++)
        {
            for (int j = space; j >= 0; j--)
            {
                Console.Write(" ");
            }

            for (int s = 1; s <= i; s++)
            {
                Console.Write(s);
            }

            for (int k = i - 1; k >= 1; k--)
            {
                Console.Write(k);
            }

            Console.WriteLine();
            space--;
        }
    }
}