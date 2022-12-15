/*
Задача 52. Задайте двумерный массив из целых чисел.
 Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

создать матрицу
распечатать матрицу
посчитать среднее арифметическое
*/

int [,] GetMatrix()
{
    Random rnd = new Random();
    int m = rnd.Next(1, 10),
        n = rnd.Next(1, 10);
    int [,] matrix = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rnd.Next(1, 100);
        }
    }
    return matrix;
}

void PrintMatrix(int [,] matrix)
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

//нахождение и распечатка  среднего арефмтического каждого столбца
void ColumArithmeticMean(int[,] matrix)
{
    double result;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        result = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            result += matrix[j, i];
        }
        Console.Write(result/matrix.GetLength(0)+"; ");
    }
}

int[,] matrix = GetMatrix();
PrintMatrix(matrix);
Console.WriteLine();
ColumArithmeticMean(matrix);
