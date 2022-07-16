/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

double[] CreateArray(int size)
{
    double[] newArray = new double[size];
    for(int i = 0; i < size; i++)
    newArray [i] = new Random().Next(1,22)+ new Random().NextDouble();
    Console.WriteLine();
    return newArray;
}

double SortingArray(double[] array)
{
	double max = array[0];
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
        if(array[i] < min) min = array[i];
    }
    double diff = max - min;
        return diff;
    }
void ShowArray(double[] array)
{
    	for(int i = 0; i < array.Length; i++)
         Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.WriteLine("Input a size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] array = CreateArray(size);
ShowArray(array);
double diff = SortingArray(array);
Console.WriteLine("Difference is: " + SortingArray(array));



