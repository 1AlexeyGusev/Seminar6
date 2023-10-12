// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Enter b1:");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter k1:");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter b2:");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter k2:");
double k2 = double.Parse(Console.ReadLine());


    double x = 0;
    double y = 0;
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine($"[{x}; {y}]");

//----------------------------------------------------------------

void FillArray (double[] array) // Вводим b1, k1, b2, k2
{
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
}

void LineIntersecrion (double[] array)
{
    double x = (array[0] - array[2])/ (array[3] - array[1]);
    double y = (array[3] * x) + array[2];
    Console.WriteLine($"Точка пересечения двух прямых: [{x},{y}]");
}

double[] Lines = new double[4]; // массив хранения переменных b1, k1, b2, k2
Console.WriteLine ("Введите b1, k1, b2, k2:");
FillArray (Lines);
LineIntersecrion (Lines);


