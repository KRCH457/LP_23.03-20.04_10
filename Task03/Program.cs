﻿// See https://aka.ms/new-console-template for more information
// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите число, которому соответствует день недели");
string day = Console.ReadLine();
if (day == "1")
{
    Console.WriteLine("Понедельник"); 
}
else if (day == "2")
{
    Console.WriteLine("Вторник"); 
}
else if (day == "3")
{
    Console.WriteLine("Среда"); 
}
else if (day == "4")
{
    Console.WriteLine("Четверг"); 
}
else if (day == "5")
{
    Console.WriteLine("Пятница"); 
}
else if (day == "6")
{
    Console.WriteLine("Суббота"); 
}
else if (day == "7")
{
    Console.WriteLine("Воскресенье"); 
}
else 
{
    Console.WriteLine("Это не день недели"); 
}