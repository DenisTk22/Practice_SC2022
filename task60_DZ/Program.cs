// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int ReadInt(string massage)
{
    Console.WriteLine(massage); 
    return Convert.ToInt32(Console.ReadLine());
}

int [,,] GetRandom3DMatrix(int dep, int rows, int columns)
{
    int[,,] Depmatr = new int[dep, rows, columns];
    int dd = 10;
        for (int i = 0; i < Depmatr.GetLength(0); i++)
        {
            for (int j = 0; j < Depmatr.GetLength(1); j++)
            {
                for (int k = 0; k < Depmatr.GetLength(2); k++)
                {
                    {
                        Depmatr[i, j, k] = dd;
                        dd++;
                    } 
                }
            }
           
        }
    
    return Depmatr;
}

void PrintMatrix(int[,,] anymatr)
{
    for (int i = 0; i < anymatr.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < anymatr.GetLength(1); j++)
            {
                Console.WriteLine();
                for (int k = 0; k < anymatr.GetLength(2); k++)
                {
                    {
                        Console.Write($"{anymatr[i, j, k]}" + $"({i},{j},{k})" + " ");
                    } 
                }
            }
        }
}

int depCount = ReadInt("Введите глубину матрицы:");
int rowsCount = ReadInt("Введите число строк:");
int columnCount = ReadInt("Введите число столбцов:");
int[,,] depmatrix = GetRandom3DMatrix(depCount, rowsCount, columnCount);
PrintMatrix(depmatrix);