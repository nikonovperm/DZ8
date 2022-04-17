/* Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц. */

int[,] Generate2DArray(int row, int col)
{
    int[,] getArray = new int[row,col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            getArray[i,j] = new Random().Next(0,11);
        }
    }
    return getArray;
}

void PrintArray(int[,] getArray)
{
    for (int i = 0; i < getArray.GetLength(0); i++)
    {
        for (int j = 0; j < getArray.GetLength(1); j++)
        {
            Console.Write($"{getArray[i,j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] ProductOfTwoArrays(int[,] getArray1, int[,] getArray2)
{
    int[,] getArray3 = new int[getArray1.GetLength(0), getArray1.GetLength(1)];
    for (int i = 0; i < getArray1.GetLength(0); i++)
    {
        for (int j = 0; j < getArray1.GetLength(1); j++)
        {
            getArray3[i,j] = getArray1[i,j] * getArray2[i,j];
        }
    }
    return getArray3;    
}

Console.Write("Введите количество строк двух двухмерных массивов: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите количество столбцов двух двухмерных массивов: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] getArray1 = Generate2DArray(row, col);
Console.WriteLine("Первый массив:");
PrintArray(getArray1);
Console.WriteLine();

int[,] getArray2 = Generate2DArray(row, col);
Console.WriteLine("Второй массив:");
PrintArray(getArray2);
Console.WriteLine();

int[,] getArray3 = ProductOfTwoArrays(getArray1, getArray2);
Console.WriteLine("Произведение двух массивов:");
PrintArray(getArray3);