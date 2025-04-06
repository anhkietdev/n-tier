public class Practise
{

    public int[] ProcessArray()
    {
        Console.WriteLine("Enter the number of elements in the array");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter the elements of the array");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        return arr;
    }
    public void DisplayArray(int[] inputArray)
    {
        Console.WriteLine("The elements of the array are:");
        for (int i = 0; i < inputArray.Length; i++)
        {
            Console.WriteLine(inputArray[i]);
        }
    }

    public void FindMax()
    {
        int[] arr = ProcessArray();
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        Console.WriteLine($"Max: {max}");
    }

    public void FindMin()
    {
        int[] arr = ProcessArray();
        int min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        Console.WriteLine($"Min: {min}");
    }

    public void SumAll()
    {
        int[] arr = ProcessArray();
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine($"Sum: {sum}");
    }

    public void GetAverage()
    {
        int[] arr = ProcessArray();
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        int average = sum / arr.Length;
        Console.WriteLine($"Average: {average}");
    }

    public void ReverseArray()
    {
        int[] arr = ProcessArray();
        int[] reversedArray = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            reversedArray[i] = arr[arr.Length - 1 - i];
        }

        Console.WriteLine("Array after reversed: " + string.Join(", ", reversedArray));
    }
}