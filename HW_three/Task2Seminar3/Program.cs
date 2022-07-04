void ThirdPower(int num)
{
    	for(int current = 1; current <= num; current++)
	    {
            int cube = current * current * current;
            Console.WriteLine(cube + " ");
        }
}
Console.WriteLine("Input positive int number ");
int num = Convert.ToInt32(Console.ReadLine());

ThirdPower(num);
