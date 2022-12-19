/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 
1 строка
*/
/*
создать 2д массив
подсчет суммы чисел в строках и записать их в новый 1д массив
найти номер наименьшего числа в 1д массиве
*/

int[,] rectangle =
{
    {1,3,5,7,1},
    {3,5,7,3,8},
    {4,6,43,7,3},
    {5,7,4,77,3},
    {5,7,43,7,2}
};

int[] StringSum(int[,] matrix)
{
    int[] result = new int[matrix.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        result[i] = sum;
        sum = 0;
    }
    return result;
}

int MaxArrayIndex(int[] array)
{
    int result = -1;
    int max = array.Max();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i] == max)
        {
            result = i;
            break;
        }
    }
    return result;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

PrintMatrix(rectangle);
int[] a = StringSum(rectangle);
Console.WriteLine();
Console.WriteLine($"строка {MaxArrayIndex(a) + 1}");