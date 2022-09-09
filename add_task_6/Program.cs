// Пользователь вводит координаты двух точек A и B на плоскости. 
// Программа определяет, какая из них дальше от начала координат.

using System;

Console.WriteLine("Введите координаты первой точки (X Y) через пробел: ");
String xy = Console.ReadLine();
string[] parts = xy.Split(' ');
int xA = int.Parse(parts[0]);
int yA = int.Parse(parts[1]);

Console.WriteLine("Введите координаты второй точки (X Y) через пробел: ");
xy = Console.ReadLine();
parts = xy.Split(' ');
int xB = int.Parse(parts[0]);
int yB = int.Parse(parts[1]);

double Distance1 = Math.Round(Math.Sqrt(Math.Pow(xA, 2) + Math.Pow(yA, 2)), 3, MidpointRounding.AwayFromZero);
double Distance2 = Math.Round(Math.Sqrt(Math.Pow(xB, 2) + Math.Pow(yB, 2)), 3, MidpointRounding.AwayFromZero);
Console.WriteLine($"Расстояние точек до О(0; 0): от 1 = {Distance1}, от 2 = {Distance2}");

if (Distance1 == Distance2)
{
    Console.WriteLine("Точки находятся на одинаковом расстоянии от О(0; 0)");
}
else if (Distance1 < Distance2)
{
    Console.WriteLine("От начала координат дальше расположена вторая точка");
}
else 
{
    Console.WriteLine("От начала координат дальше расположена первая точка");
}