// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9

int mun = 2;
int nun = 3;

int Akker (int m, int n)
{
    if (m < 0 || n < 0) return -1;
    if (m == 0) return n+1;
    if (n == 0) return Akker(m-1, 1);
    int a = Akker((m-1), (Akker(m, n-1)));
    return a;
}

Console.WriteLine(Akker(mun, nun));