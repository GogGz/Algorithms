namespace Searching;
class Program
{
    static void Main(string[] args)
    {

        int[] arr = new int[20];



        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = i * 2;
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        Console.Write ("Insert number to find index: ");
        int find = int.Parse(Console.ReadLine());

        Console.WriteLine("Index: " + FindIndex(arr, find, 0, arr.Length - 1));

        }
     

    public static int FindIndex(int[] a, int number,int start, int end)
    {
        if (a[start] == number)
        {
            return start;
        }
        else if (a[end] == number)
        {
            return end;
        }
        else if (a[(start + end)/2] > number)
        {
            end = (start + end) / 2;
        }
        else
        {
            start = (start + end) / 2;
        }

           return FindIndex(a, number, start, end);
        
       
    }
}

