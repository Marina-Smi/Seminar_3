
/*
//Задача Напишите программу которая принимает на вход координаты точки и выдает номер четверти в которой она находится

int FindQuart(double x, double y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;

    return 0;
}
Console.Write( "input first number: " );
double xA = Convert.ToInt32(Console.ReadLine());
 Console.Write( "input second number: ");
double yA = Convert.ToInt32(Console.ReadLine());

int quartNum = FindQuart(xA ,yA);
if (quartNum == 0)
{
    Console.WriteLine ("Point on the axes!");
}
else
{
    Console.WriteLine ($"point is located on {quartNum} quart");
}

//Задача Напишите программу которая  по заданному номеру четверти показывает диапазон  возможных координат точек

void FindRange (int quart)
{
    if (quart == 1)
    Console.WriteLine("Range (x+;y+)");
    if (quart == 2)
    Console.WriteLine("Range (x-;y+)");
    if (quart == 3)
    Console.WriteLine("Range (x-;y-)");
    if (quart == 4)
    Console.WriteLine("Range (x+;y-)");
    if (quart < 1 || quart > 4)
    Console.WriteLine ("ERROR!!!");
}

Console.Write( "input number quart: " );
int quart = Convert.ToInt32(Console.ReadLine());

FindRange(quart);
*/

// задача напишите программу которая принимает на вход координаты 2х точек и находит расстояние между ними  в 2Д пространстве

double FindDistance(double xA,double yA, double xB, double yB)
{
 return Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2));
}
Console.Write("input xA: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("input yA: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("input xB: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("input yB: ");
double y2 = Convert.ToDouble(Console.ReadLine());

double coordinate = FindDistance(x1, y1, x2, y2);
Console.WriteLine($"Distanse is {coordinate}");



