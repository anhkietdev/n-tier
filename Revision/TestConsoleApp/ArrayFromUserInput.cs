public class Practise
{
    public void UserInputArray()
    {
        Console.WriteLine("Enter the number of elements in the array");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter the elements of the array");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("The elements of the array are:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }

    public void FindMax()
    {
        Console.WriteLine("Enter the number of elements in the array");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter the elements of the array");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int max = arr[0];
        for (int i = 1; i < n; i++)
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
        Console.WriteLine("Enter the number of elements in the array");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter the elements of the array");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int min = arr[0];
        for (int i = 1; i < n; i++)
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
        Console.WriteLine("Enter the number of elements in the array");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter the elements of the array");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine($"Sum: {sum}");
    }

    public void GetAverage()
    {
        Console.WriteLine("Enter the number of elements in the array");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter the elements of the array");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += arr[i];
        }
        int average = sum / n;
        Console.WriteLine($"Average: {average}");
    }
}