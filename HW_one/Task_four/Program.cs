/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.*/

int N,current;

Console.WriteLine("Input a number: ");
N = Convert.ToInt32(Console.ReadLine());

current = (N / N)+1;

while(current <= N)
{
	Console.WriteLine(current + " ");
	current = current +2;
}