// Напишите программу, которая будет создавать 
// копию заданного массива с помощью поэлементного копирования.

int [] CopyArray(int [] array){
int [] arrayCopy = new int [array.Length];
for (int i = 0; i < array.Length; i++)
{
    arrayCopy[i] = array[i];
    Console.Write ($"{arrayCopy[i]} ");
}
return arrayCopy;
}    

int [] array1 = new int [] {1,2,3,4,5,6};
CopyArray (array1);

//----------------------------------------------------------------

int [] CopyArray(int [] array){
int [] arrayCopy = new int [array.Length];
for (int i = 0; i < array.Length; i++)
{
    arrayCopy[i] = array[i];
    Console.Write ($"{arrayCopy[i]} ");
}
return arrayCopy;
}    

int numberForArray = Convert.ToInt32(Console.ReadLine());
int [] array1 = new int [numberForArray];
for (int i = 0; i < numberForArray; i++)
{
    array1[i] = new Random().Next(0,10);
    Console.Write($"{array1[i]},");
}
Console.Write("\n");

CopyArray (array1);