/*

 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumber()
{
    int sum = 0;
    int temp = 0;
    int copyNumber = number;
    while (copyNumber > 0)
    {
        temp = copyNumber % 10;
        copyNumber = copyNumber / 10;
        sum = sum + temp;
    }
    return sum;
}

int result = SumNumber();
Console.WriteLine($"{number} --> {result}");