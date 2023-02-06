using System;
class Fabonaci
{
    public int start = 1;
    public int forward = 1;
    public int sum; 
    public void PrintFabonaciNumbers()
    {
        Console.Write("How many numbers you want in the fabo series: ");
        
        int faboNo = int.Parse(Console.ReadLine());
        int[] faboArray = new int[faboNo];

        for(int i = 0; i<faboNo; i++)
        {
            sum = start + forward;
            faboArray[i] = start;
            Console.Write($"{start} ");
            start = forward;
            forward = sum;
        }

        Console.WriteLine();
        Console.WriteLine(new string ('-',40));

        for(int i = 0; i<faboArray.Length; i++)
        {
            for(int j = 0; j<=i; j++)
            {
                Console.Write(faboArray[j] + "        ");
            }
            Console.WriteLine();
        }
    }
}