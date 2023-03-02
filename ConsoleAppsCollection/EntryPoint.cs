namespace TriangleAlpha;
class EntryPoint
{
    static void Main(string[] args)
    {
        // Fabonaci faboObj = new Fabonaci();
        // faboObj.PrintFabonaciNumbers();

        // Console.WriteLine();

        // AlphabetTriangle alphaObj = new();
        // alphaObj.PrintAlphabetTriangle();

        // NumberTriangle NumObj = new();
        // NumObj.PrintNumberTriangle();


        /*
        Binary Search algorithm
        */
         int searchingFor;
        int[] array = { 1, 2, 6, 8, 13, 55, 56, 73, 84, 104, 156 };

        Console.Write("The numbers in array are:  ");
        array.ToList().ForEach(i => Console.Write(i.ToString() + " "));
        Console.WriteLine();
        Console.Write(" Enter a number to find it's position: ");

        searchingFor = int.Parse(Console.ReadLine());

        

        BinarySearchProgram obj = new();
        obj.BinarySearchMethod(searchingFor,array);
    }
}
