//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
//показывает вторую цифру этого числа.
// ​
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 999 || number < 100)
{
    Console.WriteLine("Вы ввели цифру не из указанного диапазона.");
}
else
{
    int number1 = number % 10;
    int number2 = ((number - number1) % 100) / 10;

    Console.WriteLine(number2);
}


