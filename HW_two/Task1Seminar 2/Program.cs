/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.*/

int CutNumber()
{
    int num = new Random().Next(100,1000);
Console.WriteLine("Current random number is " + num);

        int des = (num % 100) / 10;             
        
    int result = des;
return result;
}

int number = CutNumber();
Console.WriteLine("Result number is " + number);