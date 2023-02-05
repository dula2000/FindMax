internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the array input");
        int size =int .Parse(Console.ReadLine());
        double[] items= new double[size];
         Random rand = new Random();

        for(int i=0; i<size; i++)
        {
            items[i] = rand.NextDouble()*100;
        }
        Console.WriteLine("The elements are in the array is : \t");
        for(int i=0; i<size; i++)
        {
            Console.WriteLine(items[i]);
        }

        Console.WriteLine("\n\nMax Number is in the array is " +FindMax(items,size));
    }

    static double FindMax(double[] items, int length)
    {
        if(length == 0) 
            return 0;
        //  throw new System.ArgumentException("Array is Empty");

        double max = items[0];
        for(int i=0; i<length; i++)
        {
            if (items[i]>max)
            {
                max = items[i];
            }
        }
        return max; 
    }
}