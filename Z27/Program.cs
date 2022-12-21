// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


Console.WriteLine("Введите число:  ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр = {GetColNum(num)}");

int GetColNum(int number)
{
    int count = 0;
    int sum = 0;
   while (number > 0)
   {
   sum = sum + (number%10);
   number = number/10;
   
   count++;
   }
   return sum;
}

