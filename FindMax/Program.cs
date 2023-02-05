internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the array input");
        int size =int .Parse(Console.ReadLine());
        double[] arr= new double[size];
         Random rand = new Random();

        for(int i=0; i<size; i++)
        {
            arr[i] = rand.NextDouble()*100;
        }
        Console.WriteLine("The elements are in the array is : \t");
        for(int i=0; i<size; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}