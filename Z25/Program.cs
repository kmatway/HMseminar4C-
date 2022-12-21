// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

Console.WriteLine("Введите число A:  ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B:  ");
int b = int.Parse(Console.ReadLine());

if(b > 0)
{
    Console.WriteLine($"Ответ = {GetExpo(a,b)}");
}
else
{
    Console.WriteLine("Число B не является натуральным");
}

int GetExpo(int numberA, int numberB)
{
    int result = 1;
    int count = 1;
    while (count <= numberB)
    {
        result = result * numberA;
        count++;
    }
    return result;
}

