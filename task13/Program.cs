//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()?? "");
int mem = num;

if(num>100 || num<= -100)
{
    while(num>999 || num< -999)
    {
        num/=10;
    }
    Console.WriteLine(mem + " -->" + Math.Abs(num % 10));
}
else
{
    Console.WriteLine("третьей цифры нет");
}