/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
// получение числа
int GetNumber(string messeg)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(messeg);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0) break;
        else Console.WriteLine("Введино не число или число меньше 1");
    }
    return result;
}

int GetValues(int num, int m)
{
    if (num >= m)
    {
        return (GetValues(num - 1, m) + num);
    }
    else return 0;
}

int m = GetNumber("Введите начальное число отсчета: "),
    n = GetNumber("Введите конечное число отсчета: "),
    sum = GetValues(n, m);
if (sum == 0)
{
    Console.WriteLine("Начальное число больше конечного. Не удолось произвести вычесления. Попрубуйте снова");
}
else
    Console.WriteLine(sum);