﻿int[,] CreateRandom2dArray(int rows, int columns)
{
	int[,] newArray = new int[rows, columns];
	for(int i = 0; i < rows; i++)
		for(int j= 1; j < columns; j++)
			newArray[i,j] = new Random().Next(1,9);
	return newArray;
}
void FindSrSum(int[,] array)
{
	double[] sum = new double[array.GetLength(1)];
	for(int j = 0; j < array.GetLength(1); j++)
	{
		for(int i = 0; i < array.GetLength(0); i++)
		{
			sum[j] = sum[j] + array[i, j];
		}
		sum[j] = sum[j] / array.GetLength(1);
	Console.WriteLine($"Среднеарифметическое значение элементов столбца {j} = {sum[j]}");
	}

}
void Show2dArray(int[,] array)
{
 	for(int i = 0; i < array.GetLength(0); i++)
	{
		for(int j = 0; j < array.GetLength(1); j++)
		Console.Write(array[i,j] + " ");
	Console.WriteLine();
	}
}

Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m,n);
Show2dArray(myArray);
FindSrSum(myArray);
