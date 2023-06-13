//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

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

void SortArray(int[,] inArr)
{
    for (int i = 0; i < inArr.GetLength(0); i++)
    {
        for (int j = 0; j < inArr.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < inArr.GetLength(1) - j - 1; k++)
            {
                if (inArr[i, k] < inArr[i, k + 1])
                {
                    int temp = inArr[i, k];
                    inArr[i, k] = inArr[i, k + 1];
                    inArr[i, k + 1] = temp;
                }
            }
        }
    }
    PrintArray(inArr);
}

int[,] array = GetArray(3, 4, 0, 10);
Console.WriteLine("полученный массив: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("упорядоченный массив: ");
SortArray(array);