/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.*/

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

int[,] SelectionSort(int[,] array)
{
    for(int minPosition = 0; minPosition < array.GetLength(0); minPosition++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = array.GetLength(1) - 1; j > i; j--)
            {
            if (array[minPosition, j-1] > array[minPosition,j])
            {
            int temp = array[minPosition, j-1];
            array[minPosition, j-1] = array[minPosition, j];
            array[minPosition, j] = temp;
            }
        }
    }
        
} 
Console.WriteLine();
return array;
}
Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m,n);
Show2dArray(myArray);
Show2dArray(SelectionSort(myArray));

