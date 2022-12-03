//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.WriteLine("Введите 3 числа по очереди");
int a = int.Parse(Console.ReadLine()?? "");
int b = int.Parse(Console.ReadLine()?? "");
int c = int.Parse(Console.ReadLine()?? "");

int max = a;

if(b>max)
{
    max = b;

}
if(c>max)
{
    max = c;
}
Console.WriteLine("max-->" +max);