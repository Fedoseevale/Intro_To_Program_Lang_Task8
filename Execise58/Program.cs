// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // 0 - rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 - colomns
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int[,] MultiplicationMatrix1Matrix2 (int[,] matrix1, int[,] matrix2)
{
    int[,] matrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++) // 0 - rows
    {
        for (int j = 0; j < matrix2.GetLength(1); j++) // 1 - colomns
        {
            matrix [i,j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++) 
            {
                matrix [i,j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrix;
}

Console.WriteLine("Имеется матрица 1: ");
int[,] array2DNumber1 = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2DNumber1);
Console.WriteLine("Имеется матрица 2: ");
int[,] array2DNumber2 = CreateMatrixRndInt(4, 5, 1, 10);
PrintMatrix(array2DNumber2);
Console.WriteLine();

if (array2DNumber1.GetLength(1) == array2DNumber2.GetLength(0))
{
    Console.WriteLine("Результат перемножения матриц: ");
    int[,] array2DNumber3 = MultiplicationMatrix1Matrix2(array2DNumber1, array2DNumber2);
    PrintMatrix(array2DNumber3);
}
else Console.WriteLine("Не выполняется условие возможности перемножения матриц");


