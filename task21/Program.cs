//ДЗ задача 21  Напишите программу которая на вход принимает координаты двух точек и находит 
//  расстояние между ними в 3D пространстве.
//  A (3,6,8) B (2,1,-7)--> 15,84
//  A (7,-5,0) B (1,-1,9)--> 11,53

Console.WriteLine("Введите координаты x точки а");
int ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y точки а");
int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты z точки а");
int az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты x точки b");
int bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y точки b");
int by = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты z точки b");
int bz = Convert.ToInt32(Console.ReadLine());

double dist = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
Console.WriteLine($"Расстояние между двумя точками равно {dist}");
