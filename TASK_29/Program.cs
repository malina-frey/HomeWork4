/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

void FiilArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = new Random().Next(0, 100);
    }
}
void PrintArray(int[] array2)
{
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write(array2[i]);
        if (i != array2.Length-1)
        {
            Console.Write(", ");
        }
    }
}

int[] array = new int[8];
FiilArray(array);
PrintArray(array);
Console.Write("-> [  ");
PrintArray(array);
Console.Write("] ");