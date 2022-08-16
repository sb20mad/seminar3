// Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
//            причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координаты X ");
int X = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Y ");
int Y = Convert.ToInt32(Console.ReadLine());

if (X>0 && Y>0)
{
    Console.WriteLine("Находится в 1 четверти");
}
else if (X<0 && Y>0)
{
Console.WriteLine("Находится в 2 четверти");
}
else if (X<0 && Y<0)
{
Console.WriteLine("Находится в 3 четверти");
}
else if (X>0 && Y<0)
{
Console.WriteLine("Находится в 4 четверти");
}
else
{
Console.WriteLine("Координаты не могут быть равны 0");
}