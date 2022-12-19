/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1
*/
int GetNumber(string masseg)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(masseg);
        if (int.TryParse(Console.ReadLine(), out result)) break;
        else Console.WriteLine("Введено не число. Введдите число");
    }
    return result;
}

int[,,] Fill3dMatrix(int height, int width, int length)
{
    int[,,] result = new int[height, width, length];
    Random rnd = new Random();
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            for (int k = 0; k < length; k++)
            {
                result[i, j, k] = rnd.Next(-99, 100);
            }
        }
    }
    return result;
}

void Print3dMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int l = 0; l < matrix.GetLength(2); l++)
            {
                Console.Write($"{matrix[i, j, l]}({i},{j},{l}) ");
            }
        }
        Console.WriteLine();
    }
}

int i = GetNumber("Введите высоту массива");
int j = GetNumber("Введите ширину массива");
int k = GetNumber("Введите длину массива");

Print3dMatrix(Fill3dMatrix(i, j, k));