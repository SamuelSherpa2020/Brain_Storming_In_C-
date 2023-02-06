namespace FabonaciTriangle;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("How many numbers do you want to see in fabonaci series ? : ");
       
        int terms = int.Parse(Console.ReadLine());
       
        int[] faboArray = new int[terms];
       
        int start = 1;
        int forward = 1;
        int sum;
       
        for (int i = 0; i < terms; i++)
        {
            sum = start + forward;
            faboArray[i] = start;
            Console.Write($"{start} ");
            start = forward;
            forward = sum;
        }
        Console.WriteLine();
        Console.WriteLine(new string('-',40));
        
        for (int i = 0; i < faboArray.Length; i++)
        {
            for(int j = 0; j<=i; j++)
            {

            Console.Write(faboArray[j]+"         ");
            }
            Console.WriteLine();
        }
    }
}
