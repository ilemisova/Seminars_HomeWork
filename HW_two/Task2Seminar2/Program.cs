/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.*/

int CutNumber()
{
	
    int num = new Random().Next(1,1000);
	Console.WriteLine("Current randome number is " + num);
    {
        if (num < 100) num = -1;
        else
        { while(num >= 1000)
            num = num / 10; 
            num = num % 10;
        }
    }
	return num;
}
int num = CutNumber();
Console.WriteLine("Your number is " + num);
