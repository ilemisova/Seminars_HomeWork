
int[] CreateRandomArray(int size)
{
        int[] newArray = new int[size];
        for(int i = 0; i < size; i++)
		newArray[i] = new Random().Next(100, 999);
    Console.WriteLine();
    return newArray;
}

int SortingArray(int[] array)
{
	int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i]%2 == 0) count ++;
    return count;
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
int Count = SortingArray(array);
Console.WriteLine("Count even is " + Count);
