
// Задача 54: Задайте двумерный массив. 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();
    for (int n = 0; n < matrix.GetLength(0); n++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[n, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void RowSortMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1); k++)
            {
                if (matr[i, j] > matr[i, k])
                {
                    var temp = matr[i, j];
                    matr[i, j] = matr[i, k];
                    matr[i, k] = temp;
                }
            }
        }
    }
}

void PrintMatrix(int[,] matrix) 
{ 
    for (int i = 0; i < matrix.GetLength(0); i++) 
    { 
        Console.Write("|"); 
        for (int j = 0; j < matrix.GetLength(1); j++) 
        { 
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, "); 
            else Console.Write($"{matrix[i, j],4} "); 
        } 
        Console.WriteLine("|"); 
    } 
} 

int[,] array2D = CreateMatrixRndInt(4, 10, 1, 10);
PrintMatrix(array2D);
Console.WriteLine("");
RowSortMatrix(array2D);
PrintMatrix(array2D);

