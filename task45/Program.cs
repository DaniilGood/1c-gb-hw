/*Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.*/

//поэлементное копирование массива
int[] ArrayCopy(int[] array)
{
    int length = array.Length;
    int[] result = new int [length];
    for (int i = 0; i < length; i++)
    {
        result[i] = array[i];
    }
    return result;
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

int[] collection ={1,4,6,-8,6,5,3,33,44};
int[] copy = ArrayCopy(collection);

PrintArray(copy);