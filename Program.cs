//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

string listN(int n)
{
    if(n == 1) return "1";

    return  n + ", " + listN(n - 1);
}

Console.Write("Введите N? ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write(listN(n));