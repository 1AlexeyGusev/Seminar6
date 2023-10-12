// Напишите программу, которая будет преобразовывать
//  десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// Console.WriteLine("Введите число:" );
// int n = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// double newn = 0;
// while (n >= 1)
// {
//  newn=n%2*Math.Pow(10, count) + newn;
//  n=n/2;
//  count++;
// }
// Console.WriteLine(newn);


//--------------------------------------------------------------------------

Console.WriteLine("Введите число:" );
int n = Convert.ToInt32(Console.ReadLine());

string n2 = "";

while (n > 0)

{
    n2 += Convert.ToString(n % 2);
    n = n / 2;
}
for (int i = n2.Length -1; i >= n; i--)
{
    Console.Write(n2[i]);
}

//--------------------------------------------------------------------------

Console.WriteLine("Введите число:" );
int n = Convert.ToInt32(Console.ReadLine());

string n2 = "";

while (n > 0)
{
    n2 = Convert.ToString(n % 2) + n2;
    n /= 2;
}

Console.WriteLine(n2);

