﻿// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int num = 2;
int st = 3;
int dig (int n, int m)
{
    if(m <= 0) return 1;
    if(n < 0) return -1;
    int s = n*dig(n, m-1);
    return s;
}

Console.WriteLine(dig(num, st));