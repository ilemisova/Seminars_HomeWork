/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Пограмма считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int[,] CreateRandom2dArray(int rows, int columns)
{
	int[,] newArray = new int[rows, columns];
	for(int i = 0; i < rows; i++)
		for(int j = 0; j < columns; j++)
			newArray[i,j] = new Random().Next(1,9);

	return newArray;
}
int FindSum(int[,] array)
{
    int minSum = 0;
    int count = 0;
	
	for(int i = 0; i < array.GetLength(0); i++)
	{   
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
            { sum = sum + array[i, j];}
        if(i == 0) minSum = sum;
        if(sum < minSum)
        {
            minSum = sum;
            count = i;
        }
    }    
	return count; 

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
FindSum(myArray);
Console.WriteLine($" The rows with min amount is " + FindSum(myArray));
