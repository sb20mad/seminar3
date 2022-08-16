// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит
//            расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


// double n = Math.Pow(n,3);

// //Корень
// double s = 125;
// double i = Math.Sqrt(s);

Console.WriteLine("Введите координаты xа ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты yа ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты xb ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты yb ");
int yb = Convert.ToInt32(Console.ReadLine());
double resx = Math.Pow(xb-xa, 2);
double resy = Math.Pow(yb-ya, 2);
double i = Math.Sqrt(resx+resy);
Console.WriteLine(i);





// Console.WriteLine("Введите номер четверти координат ");
// int X = Convert.ToInt32(Console.ReadLine());

// // Console.WriteLine("Введите координаты Y ");
// // int Y = Convert.ToInt32(Console.ReadLine());

// if (X==1)
// {
//     Console.WriteLine("X>0 Y>0");
// }
// else if (X==2)
// {
// Console.WriteLine("X<0 Y>0");
// }
// else if (X==3)
// {
// Console.WriteLine("X<0 Y<0");
// }
// else if (X==4)
// {
// Console.WriteLine("X>0 && Y<0");
// }
// else
// {
// Console.WriteLine("Введите номер четверти от 1 до 4");
// }
//Степень
