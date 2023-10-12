// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[n];
arr[0] = 0;
arr[1] = 1;
for (int i = 2; i < n; i++)
{
    arr[i] = arr[i-1] + arr[i-2];
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("\b\b]\n");
}

PrintArray(arr);