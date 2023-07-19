// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Clear();
Console.WriteLine("Введите число a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b:");
int b = Convert.ToInt32(Console.ReadLine());
int result = a;

if (b == 0) 
    {
        Console.WriteLine(result = 1);
        return;       
    }
else 

    for (int i = 1; i <= b-1; i++)
    {
        result = result * a;     
    }

Console.WriteLine(result);

