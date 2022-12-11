//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void FillArray(int[] collection)
{
    int n = collection.Length;
    int index = 0;
    while(index<n)
    {
        collection[index] = new Random().Next(-1000, 1000);
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

int[] array= new int[new Random().Next(1, 10)];
FillArray(array);
int amount=0;
for (int i = 0; i < array.Length; i=i+2)
{
    amount= amount+array[i];
}

PrintArray(array);
Console.WriteLine(amount);