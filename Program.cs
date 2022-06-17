//branch 25 - Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//branch 27 - Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//branch 29 - Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Вывод сделать отдельным методом.

//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input degree number: ");
int degree = Convert.ToInt32(Console.ReadLine());
int result = 1;

for(int i = 0; i < degree; i++)
{
    result *=number;
}

Console.WriteLine($"({number})^{degree} = {result}");
