// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

using System;

Console.WriteLine("Введите три координаты первой точки (X Y Z) через пробел: ");
String xyz = Console.ReadLine();
string[] parts = xyz.Split(' ');
int xA = int.Parse(parts[0]);
int yA = int.Parse(parts[1]);
int zA = int.Parse(parts[2]);

Console.WriteLine("Введите три координаты второй точки (X Y Z) через пробел: ");
xyz = Console.ReadLine();
parts = xyz.Split(' ');
int xB = int.Parse(parts[0]);
int yB = int.Parse(parts[1]);
int zB = int.Parse(parts[2]);

// диагональ прямоугольного параллелепипеда
double Distance = Math.Sqrt(Math.Pow((xA - xB), 2) + Math.Pow((yA - yB), 2) + Math.Pow((zA - zB), 2));

Console.WriteLine("Расстояние между этими точками в 3D-пространстве = " + Distance);