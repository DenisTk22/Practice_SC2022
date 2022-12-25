// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int num = 453;
//int s = 0;
int sum (int n)
{
    if(n <= 0) return -1;
    if(n < 10) return n;
    n = n%10 + sum(n/10);
    return n;
}

Console.WriteLine(sum(num));