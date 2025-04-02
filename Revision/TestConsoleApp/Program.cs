int[] arr;
Console.Write("Nhập số phần tử của mảng: ");
int n = int.Parse(Console.ReadLine());

arr = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Nhập phần tử thứ {i + 1}: ");
    arr[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Mảng vừa nhập: " + string.Join(", ", arr));
