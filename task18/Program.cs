﻿
//Задача 18: Напишите программу, которая по заданному номеру четверти, 
//         показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти координат ");
int X = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты Y ");
// int Y = Convert.ToInt32(Console.ReadLine());

if (X==1)
{
    Console.WriteLine("X>0 Y>0");
}
else if (X==2)
{
Console.WriteLine("X<0 Y>0");
}
else if (X==3)
{
Console.WriteLine("X<0 Y<0");
}
else if (X==4)
{
Console.WriteLine("X>0 && Y<0");
}
else
{
Console.WriteLine("Введите номер четверти от 1 до 4");
}