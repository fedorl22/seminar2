// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и 
//проверяет, является ли этот день выходным.
// ​
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели, от 1 до 7. Является ли этот день выходным?:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 7 || number < 1)
{
    Console.WriteLine("Вы ввели цифру не из указанного диапазона");
}
else
{
    if (number < 6 && number > 0)
    {
        Console.WriteLine("нет");
    }
    else
        Console.WriteLine("да");
}
