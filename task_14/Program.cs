/* Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да */

void task (int a)
{
    if (a % 7 == 0 & a % 23 == 0)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
Console.WriteLine("Введите число");
int myNumber = Convert.ToInt32(Console.ReadLine());
task(myNumber);