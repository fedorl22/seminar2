﻿// Задача 16: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно 
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет


Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a*a==b || a==b*b)
{
    Console.WriteLine("Да");    
}
else
{
    Console.WriteLine("Нет");
}
