/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
int[,] matrix = new int[10, 9];

int[,] FillSpiral(int[,] spiral)
{
    int[,] matrix = new int[spiral.GetLength(0), spiral.GetLength(1)];
    int i = 0,
        j = 0,
        NumClock = 1,
        step = 0;
    matrix[0, 0] = 1;
    while (NumClock < matrix.GetLength(0) * matrix.GetLength(1))
    {
        while (j < matrix.GetLength(1) - 1 - step)
        {
            j++;
            NumClock++;
            matrix[i, j] = NumClock;
        }
        while (i < matrix.GetLength(0) - 1 - step)
        {
            i++;
            NumClock++;
            matrix[i, j] = NumClock;

        }
        while (j > 0 + step)
        {
            j--;
            NumClock++;
            matrix[i, j] = NumClock;

        }
        while (i > 1 + step)
        {
            i--;
            NumClock++;
            matrix[i, j] = NumClock;

        }
        step++;
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > 9) Console.Write(matrix[i, j] + " ");
            else Console.Write("0" + matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

PrintMatrix(FillSpiral(matrix));



