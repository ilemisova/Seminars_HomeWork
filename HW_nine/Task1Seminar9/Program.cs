/*Задача 64: Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе
рекурсивным методом.N = 4532 -> 4*/

int CountOf(int n)
{
	if(n > 9)
	{
		return 1 + CountOf(n =n / 10);
	}
	else return n;
}

Console.WriteLine(CountOf(123456));


