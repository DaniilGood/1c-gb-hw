//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(int[] collection)
{
    int n = collection.Length;
    int index = 0;
    while(index<n)
    {
        collection[index] = new Random().Next(1, 1000);
        index++;
    }
}

void PrintArray(int[] col)
{
    Console.Write("[");
    int Length = col.Length;
    int position = 0;
    while(position<Length)
    {
        Console.Write(col[position]+ ", ");
        position++;
    }
    Console.Write("]");
}

void MaxAndMin(int[] array,out int max, out int min)
{
    max=array[0];
    min=array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>max) max=array[i];
        else if (array[i]<min) min=array[i];
    }
}
int max,min;
int[] array= new int[new Random().Next(1, 1000)];
FillArray(array);
MaxAndMin(array,out max,out min);
PrintArray(array);
Console.WriteLine($"{max}-{min}={ max - min}");