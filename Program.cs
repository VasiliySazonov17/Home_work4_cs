//branch 25 - Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//branch 27 - Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//branch 29 - Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Вывод сделать отдельным методом.

Console.Write("Input length array: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int [length];

Console.WriteLine($"Input {length} numbers use 'enter': ");

for(int i = 0; i < length; i++)
{   
    Console.Write($"{i+1}) ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("You want to output an array?");
Console.Write("Yes or No: ");
string answer = Console.ReadLine();

if(answer == "Yes")
{
   for(int i = 0; i < length; i++)
   {
        Console.Write($"{array[i]}");
        if (i+1 != length)
        {
            Console.Write(", ");  
        }
        else
        {
            Console.WriteLine(". ");
        }
   } 
   
}
else
{
    Console.Write("Your answer is incorrect"); 
}



