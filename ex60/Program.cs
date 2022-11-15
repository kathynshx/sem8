// Задача 60. ...Сформируйте 
//трёхмерный массив из неповторяющихся двузначных чисел. 
//построчно выводить массив
// добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,] CreateMatrixRndInt(int z,int i, int j, int min, int max) 
{ 
   int  matrix = new int[i, j,z]; 
   int  rnd = new Random(); 
    for (int i = 0; i < matrix.GetLength(0); i++) 
    { 
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            for (int z = 0; j < matrix.GetLength(1); z++)
             { 
            matrix[i, j] = rnd.Next(min, max + 1); 
             } 
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


    int [,,] array3D = CreateMatrixRndInt(3,3,3);
    PrintArray(array3D);