// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

Console.Write("Введите число элементов массива ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число массива ");
int minArr = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число массива ");
int maxArr = Convert.ToInt32(Console.ReadLine());

void PrintArr(int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} \t");
    }
    Console.Write("\b\b\b\b]");
    Console.WriteLine();
}

int[] GenArr(int n, int min, int max)
{
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

int[] ReverseArr(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - i - 1];
        arr[arr.Length - i - 1] = temp;
    }
    return arr;
}

int[] array = GenArr(n, minArr, maxArr);
PrintArr(array);

int[] reverseArray = ReverseArr(array);
PrintArr(reverseArray);