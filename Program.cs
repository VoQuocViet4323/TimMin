internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine($"Nhập số lượng phần tử n: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        int minValue = Min(arr);
        Console.WriteLine($"Giá trị nhỏ nhất trong mảng là: {minValue}");
    }

    private static int Min(int[] arr)
    {
        int min = arr[0];
        for (int i = 1; i < arr.Length; i++) 
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        return min;
    }
}
