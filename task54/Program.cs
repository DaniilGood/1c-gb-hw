/*
Задача 54: Задайте двумерный массив. Напишите программу,
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] matrix = 
{   {1,2,4,6,8,4},
    {2,3,45,5,32,2},
    {4,6,7,9,2,2}
};
//сортировка от большего к меньшому
void SortMaxToMin(ref int[,] matrix)
{
    int NextString =1;
    int mem = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(j == matrix.GetLength(1)-1) NextString =0;
            for (int k = i+j/(matrix.GetLength(1)-1); k < matrix.GetLength(0); k++)
            {
                if(k != i) NextString =0;
                for (int l = (j+1)*NextString; l < matrix.GetLength(1); l++)
                {
                    if(matrix[i, j]<matrix[k,l])
                    {
                        mem = matrix[i,j];
                        matrix[i,j] = matrix[k,l];
                        matrix[k,l] = mem;
                    }
                }
                NextString =1;
            }
        }
    }   
}
// распечатка матрицы
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j]+" ");
        }
        Console.WriteLine();
    }
}

PrintMatrix(matrix);
SortMaxToMin(ref matrix);
Console.WriteLine();
PrintMatrix(matrix);
