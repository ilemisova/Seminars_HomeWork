void SelectionSort(int num)
    {
	if(num / 10000 == num % 10 && num / 1000 % 10 == (num % 100) / 10) Console.WriteLine("this number is palindrom ");
	else Console.WriteLine("uncorrect number! ");
    }
Console.WriteLine("Input fiveDigit number ");
int num = Convert.ToInt32(Console.ReadLine());

SelectionSort(num);
