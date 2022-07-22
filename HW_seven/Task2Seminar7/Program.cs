/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.*/
int[,] CreateRandom2dArray(int rows, int columns)
{
	int[,] newArray = new int[rows, columns];
	for(int i = 0; i < rows; i++)
		for(int j= 1; j < rows; j++)
			newArray[i,j] = new Random().Next(1,9);

	return newArray;
}


void Show2dArray(int[,] array)
{
 	for(int i =0; i < array.GetLength(0); i++)
	{
		for(int j=0; j < array.GetLength(1); j++)
		Console.Write(array[i,j] + " ");

	Console.WriteLine();
	}
}

Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your rows: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your of columns: ");
int j = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m,n);
Show2dArray(myArray);
if (i > m || j > n) Console.WriteLine($"Элемент отсутствует");
else
Console.WriteLine($"Значение элементов {myArray [i-1, j-1]}");

