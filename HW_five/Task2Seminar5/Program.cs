int[] CreateRandomArray(int size)
{
        int[] newArray = new int[size];
        for(int i = 0; i < size; i++)
		newArray[i] = new Random().Next(1, 1000);
    Console.WriteLine();
    return newArray;
}

int SortingArray(int[] array)
{
	int sum = 0;
    for(int i = 1; i < array.Length; i++)
        if(i%2 == 1) sum += array[i];
    return sum;
}
void ShowArray(int[] array)
{
	for(int i = 0; i < array.Length; i++)
         Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.WriteLine("Input a size of array: ");
int size = Convert.ToInt32(Console.ReadLine());


int[] array = CreateRandomArray(size);
ShowArray(array);
int Sum = SortingArray(array);
Console.WriteLine("Sum no even number is: " + Sum);