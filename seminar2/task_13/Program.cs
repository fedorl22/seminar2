// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// ​
// 645 -> 5
// ​
// 78 -> третьей цифры нет
// ​
// 32679 -> 6
// int.MaxValue = 2147483647

Console.WriteLine("Введите число, максимум 2147483647: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
int i = -1;
if (number > 99)
{
    while (number > 999)
    {
        number = number / 10;
    }
    i = number % 10;
    Console.WriteLine($"Третье число: {i}");
}
return i;


