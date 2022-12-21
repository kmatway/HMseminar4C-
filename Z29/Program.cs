// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] array = new int[8];
Console.WriteLine($"{FillArray(array)}");


int[] FillArray (int[]arr)
{
    int length = arr.Length;
    int i = 0;
    while(i < length)
    {
        arr[i] = new Random().Next(1,10);
        Console.WriteLine(arr[i] +" ");
        i++;
    }
    return arr;
}


