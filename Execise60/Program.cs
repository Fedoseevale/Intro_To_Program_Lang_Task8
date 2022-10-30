// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)


int[,,] Create3dArray(int rows, int columns, int depth)
{
    int[,,] array = new int[rows, columns, depth];
    int number = 10;
    for (int i = 0; i < array.GetLength(0); i++) // 0 - rows
    {
        for (int j = 0; j < array.GetLength(1); j++) // 1 - colomns
        {
            for (int k = 0; k < array.GetLength(2); k++) // 2 - depth
            {
                array[i, j, k] = number++;
            }
        }
    }
    return array;
}

void PrintArray3d(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k],3}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размер массива в первом измерении: ");
int rowsArray3D = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер массива во втором измерении: ");
int colomnsArray3D = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер массива во втором измерении: ");
int depthArray3D = Convert.ToInt32(Console.ReadLine());

if (rowsArray3D * colomnsArray3D * depthArray3D <= 90)
{
    Console.WriteLine($"Вы имеете массив размером {rowsArray3D}x{colomnsArray3D}x{depthArray3D}:");
    int[,,] array3D = Create3dArray(rowsArray3D, colomnsArray3D, depthArray3D);
    PrintArray3d(array3D);
}
else Console.WriteLine("Массив не может быть выведен, т.к. содержит трёхзначные числа");
