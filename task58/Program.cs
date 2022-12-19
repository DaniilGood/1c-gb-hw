/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

проверка
перемножение и запись в новый массив
*/

//проверка
/*
int[,] matrix1 =
{
    {1,3},
    {4,5},
    {6,4},
    {5,66}
};
int[,] matrix2 =
{
    {2,4},
    {5,6},
    {8,9}
};
*/
int[,] matrix1 =
{
    {2,4},
    {3,2}
};
int[,] matrix2 =
{
    {3,4},
    {3,3}
};

bool CheckMultiplication(int[,] mult1, int[,] mult2)
{
    if (mult1.GetLength(1) == mult2.GetLength(0)) return true;
    else return false;
}

int[,] MultiplicationMatrix(int[,] mult1, int[,] mult2)
{
    int[,] result = new int[mult1.GetLength(0), mult2.GetLength(1)];
    int sum = 0;

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < mult2.GetLength(0); k++)
            {
                sum += mult1[i, k] * mult2[k, j];
            }
            result[i, j] = sum;
            sum = 0;
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

PrintMatrix(matrix1);
Console.WriteLine("-----");
PrintMatrix(matrix2);
Console.WriteLine("-----");

if (CheckMultiplication(matrix1, matrix2) == false) Console.WriteLine("Количество столбцов в 1 матрице должно быть равно количесту строк во 2 матрице. Исправьте данную ошибку и попробуйте снова");
else PrintMatrix(MultiplicationMatrix(matrix1, matrix2));


