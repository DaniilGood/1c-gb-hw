//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void FillArray(int[] collection)
{
    int n = collection.Length;
    int index = 0;
    while(index<n)
    {
        collection[index] = new Random().Next(100, 1000);
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

int[] array= new int[new Random().Next(1, 1000)];
FillArray(array);
int amount=0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i]%2 == 0) amount++;
}

PrintArray(array);
Console.WriteLine(amount);