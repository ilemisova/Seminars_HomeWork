/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным */

void Day(int a)
{ 
    if(a == 6 ||a == 7) Console.WriteLine("Weekend ");
    else Console.WriteLine("No Weekend ");
}

Console.WriteLine("Input of day number: " );
int number = Convert.ToInt32(Console.ReadLine());
Day(number);

