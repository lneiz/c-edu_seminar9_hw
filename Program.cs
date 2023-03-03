//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

// string listN(int n)
// {
//     if(n == 1) return "1";

//     return  n + ", " + listN(n - 1);
// }

// Console.Write("Введите N? ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write(listN(n));

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// int AdditOfNum(int m, int n)
// {
//     if(n < m)
//     {
//         if(m == n) return n;

//         return m + AdditOfNum(m - 1, n);
//     }
//     else
//     {
//         if(n == m) return m;

//         return n + AdditOfNum(n - 1, m);
//     }
// }


// Console.Write("Введите N? ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите M? ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("-> " + AdditOfNum(m,n));

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AckermanFunc(int m, int n)
{
    if(m == 0) return n + 1;
    if(m > 0 && n == 0) return AckermanFunc(m - 1, 1);
    if(m > 0 && n > 0) return AckermanFunc(m - 1, AckermanFunc(m, n-1));
    return AckermanFunc(m, n);
}

Console.Write("Введите N? ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите M? ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("A(m,n) = " + AckermanFunc(m,n));