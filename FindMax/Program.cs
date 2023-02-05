internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the array input");
        int size =int .Parse(Console.ReadLine());
        int[] arr= new int[size];
         Random rand = new Random();

        for(int i=0; i<size; i++)
        {
            arr[i] = rand.Next(0, size);
        }
        for(int i=0; i<size; i++)
        {
            Console.Write(arr[i]);
        }
    }
}