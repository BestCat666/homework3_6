// Задача 43:Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Введите первую точку первой прямой(b1): ");
double b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую точку первой прямой(b2): ");
double b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первую точку второй прямой(k1): ");
double k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую точку второй прямой(k2): ");
double k2 = int.Parse(Console.ReadLine());
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"точка пересечения двух прямых = ({x} , {y})");
