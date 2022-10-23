//  Задача 21 Напишите программу, которая принимает на вход координаты двух
//  точек и находит расстояние между ними в 3D пространстве.
//  A (3,6,8); B (2,1,-7), -> 15.84
//  A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координату X для первой точки: ");
double pointX1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y для первой точки: ");
double pointY1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z для первой точки: ");
double pointZ1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату X для второй точки: ");
double pointX2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y для второй точки: ");
double pointY2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z для второй точки: ");
double pointZ2 = Convert.ToDouble(Console.ReadLine());

double Distance(double X1, double Y1, double Z1, double X2, double Y2, double Z2)
{
    double vector1 = X2 - X1;
    double vector2 = Y2 - Y1;
    double vector3 = Z2 - Z1;
    double result = Math.Sqrt(Math.Pow(vector1, 2) + Math.Pow(vector2, 2) + Math.Pow(vector3, 2));
    return result;
}

double lenghtPoints = Distance(pointX1, pointY1, pointZ1, pointX2, pointY2, pointZ2);
Console.WriteLine($"Расстояние между координатами первой точки ({pointX1}, {pointY1}, {pointZ1}) и второй точки ({pointX2}, {pointY2}, {pointZ2}) в 3D пространстве будет = {Math.Round(lenghtPoints, 2)}");