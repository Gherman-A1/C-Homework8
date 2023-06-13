//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GetRowMinSum(int[,] inArr)
{
    int minRowIndex = 0;
    int minRowSum = 0;
    for (int j = 0; j < inArr.GetLength(1); j++)
    {
        minRowSum += inArr[0, j];
    }

    for (int i = 1; i < inArr.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < inArr.GetLength(1); j++)
        {
            rowSum += inArr[i, j];
        }
        if (rowSum < minRowSum)
        {
            minRowSum = rowSum;
            minRowIndex = i;
        }
    }
    Console.WriteLine("строка с наименьшей суммой элеметов: ");
    Console.Write(minRowIndex + 1);
}
int[,] array = GetArray(3, 4, 0, 10);
Console.WriteLine("полученный массив: ");
PrintArray(array);
Console.WriteLine();
GetRowMinSum(array);