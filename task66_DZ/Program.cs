// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
//в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m1 = 4;
int n1 = 8;
int sum (int m, int n)
{
    if(m < 0) return -1;
    if(m == n) return m;
    int s = m + sum(m+1, n);
    return s;
}

Console.WriteLine(sum(m1, n1));