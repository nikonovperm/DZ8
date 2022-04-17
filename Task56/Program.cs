/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов. */

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

void FindArrayStringWithSmallestSumOfElements(int[,] getArray)
{
    int sumOfString = 0;
    int smallestSumOfString = 0;
    int i = 0;
    for (int j = 0; j < getArray.GetLength(1); j++)
    {
        smallestSumOfString += getArray[i,j];
    }
    Console.WriteLine($"Сумма {i} строки {smallestSumOfString}");
    int numberOfSmallestString = 0;

    for (i = 1; i < getArray.GetLength(0); i++)
    {
        for (int j = 0; j < getArray.GetLength(1); j++)
        {
            sumOfString += getArray[i,j];
        }
        Console.WriteLine($"Сумма {i} строки {sumOfString}");
        
        if (sumOfString < smallestSumOfString)
        {
            smallestSumOfString = sumOfString;
            numberOfSmallestString = i;
        }
        
        sumOfString = 0;
    }
    Console.WriteLine($"{numberOfSmallestString} строка с наименьшей суммой элементов");
}

Console.Write("Введите количество строк двухмерного массива: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите количество столбцов двухмерного массива: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] getArray = Generate2DArray(row, col);
PrintArray(getArray);
Console.WriteLine();

FindArrayStringWithSmallestSumOfElements(getArray);