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
        Console.WriteLine("\n\nMax Number is in the array is \n" +FindMax(items,size));

        //BucketSort
        Console.WriteLine("\nSorted array after using Bucket Sort\n");
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
        int n = items.Length;
        List<double>[] bucket = new List<double>[n];

        double maxValue= FindMax(items, length);
        for (int i = 0; i < n; i++)
        {
            bucket[i] = new List<double>();
        }

        for (int i = 0; i < n; i++)
        {
            int BucketIndex = (int)((items[i]/maxValue)*(n-1) );
            bucket[BucketIndex].Add(items[i]);
        }

        int k = 0;
        for(int i = 0; i < n; i++)
        {
            if (bucket[i].Count>0) {
                bucket[i].Sort();
                foreach (double item in bucket[i])
                {
                    items[k++] = item;
                }
            }
        }
    }


}