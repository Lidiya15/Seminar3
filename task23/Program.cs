// ДЗ Задача 23: напишите программу которая принимает на вход число (N), и выдает таблицу кубов чисел от 1 до N
// 3--1,8,27
// 5--1,8,27,64,125

Console.WriteLine("Введите число ");
int x = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= x; i++)
Console.Write($"{i*i*i} ");
