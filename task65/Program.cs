// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int num = 4;
int numup = 8;
int natur (int m, int n)
{
    if(m < 0) return -1;
    if(m == n) return m;
    Console.Write(natur(m, n-1));
    return n;
}

Console.WriteLine(natur(num, numup));

