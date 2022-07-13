//void Triangle (int a, int b, int c)
{
	if (a < b +c && b < a + c && c < a + b) Console.WriteLine(" ok ");
    else  Console.WriteLine( "No");
}
Console.WriteLine("Input num1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input num2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input num3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

Triangle(num1, num2, num3);
*/

/*Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.*/

int Fibonacci( int n)

0 1 1 2 3 5 8 13 21 34 55
{
    for (int i = 1; i < n; i++) Console.WriteLine($"F({i}) = {Fibonacci(i)}");
    (n) = f(n-1) + f(n-2);
}

Console.WriteLine("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());
