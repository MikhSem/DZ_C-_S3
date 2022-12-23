// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");

string num = Console.ReadLine();
if (num.Length<5||num.Length>5)
{
   Console.WriteLine ("Число должно содержать пять знаков");
}
else if (num[0] == num[4] && num[1] == num[3])
{
    Console.WriteLine ("Это число палиндром");
}
else 
{
    Console.WriteLine ("Это число не палиндром");
} 

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("Введите коррдинату x точки A: ");
int x1 = Convert.ToInt32(Console.ReadLine()); 
System.Console.Write("Введите коррдинату y точки A: ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите коррдинату z точки A: ");
int z1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите коордианту x точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine()); 
System.Console.Write("Введите коордианту y точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите коррдинату z точки B: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Round(Math.Sqrt(Math.Pow((x1 - x2),2) + Math.Pow((y1-y2),2) + Math.Pow((z1-z2),2)),2); 
System.Console.WriteLine($"Расстояние между точками: {result}");


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
Console.Write(Math.Pow(i, 3) + " ");
}
