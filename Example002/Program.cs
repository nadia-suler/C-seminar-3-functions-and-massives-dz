// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int xA = Coordinate("x", "A");
int yA = Coordinate("y", "A");
int zA = Coordinate("z", "A");
int xB = Coordinate("x", "B");
int yB = Coordinate("y", "B");
int zB = Coordinate("y", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write("Введите координату " + coorName + " точки " + pointName + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Введенные координаты А " + xA + ", " + yA + ", " + zA + ". Введенные координаты B " + xB + ", " + yB + ", " + zB);

int diffX = xB - xA;
int diffY = yB - yA;
int diffZ = zB - zA;
double result = Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2) + Math.Pow(diffZ, 2));

Console.WriteLine("Расстояние между точками равно " + result);

