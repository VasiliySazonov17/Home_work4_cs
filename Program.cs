﻿//branch 25 - Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//branch 27 - Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//branch 29 - Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Вывод сделать отдельным методом.

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
int count = 0;

for (int i = 0; i < number; i++)
{   
    count = number % 10;
    number /= 10;
    result += count;
}

Console.Write(result);

