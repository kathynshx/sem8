// Задача 58: Задайте две матрицы.
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Задача 58: 
//Задайте две матрицы.
//находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) 
{ 
    var matrix = new int[rows, columns]; 
    var rnd = new Random(); 
    for (int i = 0; i < matrix.GetLength(0); i++) 
    { 
        for (int j = 0; j < matrix.GetLength(1); j++) 
        { 
            matrix[i, j] = rnd.Next(min, max + 1); 
        } 
    } 
    return matrix; 
} 
void PrintArray(int[,] matrix) 
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
static int [,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    
    {       
        if (matrixA.ColumnsCount() != matrixB.RowsCount())
        {
            throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
        }

        int matrixC = new int[matrixA.RowsCount(), matrixB.ColumnsCount()];

        for (int i = 0; i < matrixA.RowsCount(); i++)
        {
            for (int j = 0; j < matrixB.ColumnsCount(); j++)
            {
                matrixC[i, j] = 0;

                for (int k = 0; k < matrixA.ColumnsCount(); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return matrixC;
    }
  
 
     


    
 int [,] array2Da= CreateMatrixRndInt(1,2,1,10);
PrintArray(array2Da);
   Console.WriteLine();
 int [,] array2Db = CreateMatrixRndInt(1,2,1,10);
 PrintArray(array2Db);
    Console.WriteLine();
MatrixMultiplication(array2Da,array2Db);
Console.WriteLine("Программа для умножения матриц");
   
        int a = matrixA("A");
        int b  = matrixB("B");

        Console.WriteLine("Матрица A:");
        Console.WriteLine(a);

        Console.WriteLine("Матрица B:");
        Console.WriteLine(b);

        var result = MatrixMultiplication(a, b);
        Console.WriteLine("Произведение матриц:");
        Console.WriteLine(result);
         Console.ReadLine();

