/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

//k1 * x + b1=k2 * x + b2; x=(b2-b1)/(k1-k2)

int GetNumber(string masseg)
{
    int result = 0;
    bool isCorect= false;

    while(!isCorect)
    {       
        Console.Write(masseg);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            isCorect = true;
        }
        else
        {
            Console.WriteLine("Введенно не число. Введите число");
        }
    }
    return result;
}

double k1 = GetNumber("Введите k1: ");
double k2 = GetNumber("Введите k2: ");
double b1 = GetNumber("Введите b1: ");
double b2 = GetNumber("Введите b2: ");
double x = (b2-b1)/(k1-k2);
Console.WriteLine($"({x},{ k1 * x + b1})");