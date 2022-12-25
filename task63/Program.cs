// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int num = 5;
int natur (int n)
{
    if(n < 0) return -1;
    if(n == 0 || n == 1) return 1;
    Console.Write(natur(n-1));
    return n;
}

Console.WriteLine(natur(num));
