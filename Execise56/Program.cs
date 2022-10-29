// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

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

int NumOfStringWithMinSumOfElementsInEachStringOfMatrix(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    int sum = default;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        array[i] = sum;
        sum = 0;
    }
    
    int minValue = array[0];
    int minElement = 0;
    for (int k = 0; k < array.Length; k++)
    {
        if (array[k] <= minValue)
        {
            minValue = array[k];
            minElement = k+1;
        }
    }
    return minElement;
}

Console.WriteLine("Задан массив: ");
int[,] array2D = CreateMatrixRndInt(5, 5, 1, 10);
PrintMatrix(array2D);
int min = NumOfStringWithMinSumOfElementsInEachStringOfMatrix(array2D);
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов: {min} ");