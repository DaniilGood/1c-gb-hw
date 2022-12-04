//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите 3х значное число: ");
int number = int.Parse(Console.ReadLine() ?? "");
if(number <= 999 && number >= 100)
{
    number= (number-number%10)%100/10;
    Console.WriteLine("Вторая цифра числа ->"+ number);
}
else
{
    Console.WriteLine("Число не верного размера");
}
