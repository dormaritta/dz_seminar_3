﻿/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.WriteLine ("Введите координату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine ("Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine ("Введите координату z1: ");
int z1 = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine ("Введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine ("Введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine ("Введите координату z2: ");
int z2 = Convert.ToInt32(Console.ReadLine()!);

double dx = x2 - x1;
double dy = y2 - y1;
double dz = z2 - z1;
double d = Math.Sqrt(dx * dx + dy * dy + dz * dz);

Console.WriteLine(d);