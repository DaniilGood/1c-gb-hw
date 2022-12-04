//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите день недели: ");
int num = int.Parse(Console.ReadLine()?? "");

if(num == 6 || num == 7)
{
    Console.WriteLine(num + "<--да ");
}
else
{
    Console.WriteLine(num + "<--нет ");
}
