int randNumber = new Random().Next(10, 100);
Console.WriteLine(randNumber);
int GetMaxLetterOfNumber(int number)
{
    int result = number % 10;
    int letter2 = number / 10;
    if (letter2 > result)
    {
        result = letter2;
    }
    return result;
}

int print= GetMaxLetterOfNumber (randNumber);
Console.WriteLine(print);