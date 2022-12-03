//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

short i=1;

if(number<0)
{
    i = -1;
    number= Math.Abs(number);
}
int index = 2;
while(index<=number)
{
    Console.Write(" " + index*i);
    index+=2;
}