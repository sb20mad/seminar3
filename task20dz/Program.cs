﻿// Задача 20
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты x1 ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y1 ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты z1 ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты x2 ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y2 ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты z2 ");
int z2 = Convert.ToInt32(Console.ReadLine());

double resx = Math.Pow(x2-x1, 2);
double resy = Math.Pow(y2-y1, 2);
double resz = Math.Pow(z2-z1, 2);
double i = Math.Sqrt(resx+resy+resz);
Console.WriteLine(i);
