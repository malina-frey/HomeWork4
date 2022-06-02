/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/




Console.WriteLine("Введите два числа: A и B ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());


int Exponentiation()
{
    int temp = 1;

    for (int i = 0; i < numberB; i++)
    {
        temp = numberA * temp;
    }
    return temp;
}

int result = Exponentiation();

Console.WriteLine("A^B = " + result);