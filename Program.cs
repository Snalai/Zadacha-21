// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// l^2 = (x2-x1)^2+(y2-y1)^2+(z2-z1)^2.
int[] FirstPoint = new int[3];
int[] SecondPoint = new int[3];
Console.WriteLine("Введите 3 координаты  первой точки: ");
int length = 3;
for (int i = 0; i < length; i++)
{
    int num = Convert.ToInt32(Console.ReadLine());
    FirstPoint[i] = num;
}
Console.WriteLine("Введите 3 координаты  второй точки: ");
for (int i = 0; i < length; i++)
{
    int num = Convert.ToInt32(Console.ReadLine());
    SecondPoint[i] = num;
}
int funk(int x)
{
    int a = ((SecondPoint[x] - FirstPoint[x]) * (SecondPoint[x] - FirstPoint[x]));
    return a;
}
int f = (funk(0) + funk(1) + funk(2));
double q = Math.Sqrt(f);
double answer = Math.Round(q, 2);
Console.WriteLine(answer);