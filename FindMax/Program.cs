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

        //display elements in the array
        Console.WriteLine("The elements are in the array is : \n");
        for(int i=0; i<size; i++)
        {
            Console.WriteLine(items[i]);
        }

        //calling the FindMax method in main method
        Console.WriteLine("\n\nMax Number is in the array is " +FindMax(items,size));

        //BucketSort
        Console.WriteLine("Sorted array after using Bucket Sort");
        BucketSort(items,size);
        DisplayArray(items);
    }

    //Display the array
    static void DisplayArray(double[] items)
    {
        foreach (double item in items) {
            Console.WriteLine(item + " ");
        }
        Console.WriteLine();
    }


    //creating a FindMAx method to find max element in the array
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
    static void BucketSort(double[] items, int length)
    {
        int NoOfBucket = (int)Math.Ceiling(length / 5.0);
        double max= FindMax(items, length);
        double[] bucket = new double[NoOfBucket];

        for(int i = 0; i < length; i++)
        {
            int BucketIndex = (int)(items[i] * NoOfBucket / max);
            bucket[BucketIndex] = items[i];
        }

        int k = 0;
        for(int i = 0; i < NoOfBucket; i++)
        {
            if (bucket[i] !=0.0) {
                items[k++] = bucket[i];
            }
        }
    }


}