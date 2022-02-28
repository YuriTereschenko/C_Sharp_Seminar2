// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
int Get2Number (int number)
{
    int result = number % 100 /10;
    return result;
}


int myNumber = 123;
int result = Get2Number(myNumber);
Console.WriteLine(result);
