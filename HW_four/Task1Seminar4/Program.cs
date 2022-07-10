int FindSum(int a)
{
	int sum = 0;
        while(a > 0)
    	{
        sum += (a % 10) ;
        a = a / 10;
        }
	return sum;
}
Console.WriteLine("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FindSum(num));