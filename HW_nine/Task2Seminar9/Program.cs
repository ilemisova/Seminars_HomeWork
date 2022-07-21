/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int SumNums(int m, int n)
{
	if(n > m)
	{
	   return n + SumNums(m, n-1);
	}
    else return n;
}

Console.WriteLine(SumNums(1,15)); 
