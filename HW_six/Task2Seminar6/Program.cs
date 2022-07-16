/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.*/

int Koord (int k1, int k2, int b1, int b2)
{
    int x = (b2 - b1) / (k1 - k2);
return x;
}

Console.WriteLine("Input k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

    if(k1 == k2) Console.WriteLine(" Will not intersect: ");

Console.WriteLine("Input b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

int x = Koord(k1, k2, b1, b2);
int y = k1*x+b1;
Console.WriteLine(x);
Console.WriteLine(y);
