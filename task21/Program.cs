//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты  первой точки  ");

Console.Write("X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int z1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите координаты второй точки  ");
Console.Write("X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int z2 = Convert.ToInt32(Console.ReadLine());


double Distance(int ax, int ay, int az, int bx, int by, int bz)
{
    return Math.Round(Math.Sqrt(((bx - ax) * (bx - ax) + (by - ay) * (by - ay) + (bz - az) * (bz - az))), 2, MidpointRounding.ToZero);
}

double result = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Растояние составляет {result}");
