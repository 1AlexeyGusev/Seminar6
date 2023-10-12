// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

bool CheckTriangle(int a, int b, int c){

    if (a + b > c && a + c > b && b + c > a)
    {
        return true;
    }
    return false;
}

Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число Б: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число С: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CheckTriangle(a, b, c));