/*задача 1*/
int a,b,max;

Console.WriteLine("Inpute a first number: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inpute a second number: ");
b = Convert.ToInt32(Console.ReadLine());

max = a;

if(a > b)
{
Console.WriteLine("max " + a);
}
{
Console.WriteLine("max " + b);
}
