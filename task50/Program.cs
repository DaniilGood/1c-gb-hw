/*
адача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
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
            matrix[i, j] = rnd.Next(-100, 100);
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

int MatrixSearch(int[,] matrix, int m, int n, out bool exist)
{
    m--;
    n--;
    exist = true;
    int result = 0;
    if(m< matrix.GetLength(0) && n< matrix.GetLength(1)) result = matrix[m,n];
    else exist = false;
    return result;
}

int m = GetNumber("Введите номер строки: ");
int n = GetNumber("Введите номер столбца: ");
int [,] matrix = GetMatrix();
PrintMatrix(matrix);
bool exist;
int lookingNum = MatrixSearch(matrix, m, n, out exist);

if(exist) Console.WriteLine(lookingNum);
else Console.WriteLine($"Числа по адресу ({n}; {m}) не существует");