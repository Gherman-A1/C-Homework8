//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int[,] GetMatrix(int m, int n, int minValue, int maxValue)
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

void PrintMatrix(int[,] arr)
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

int[,] matrixA = GetMatrix(2, 2, 2, 4);
int[,] matrixB = GetMatrix(2, 2, 2, 4);
Console.WriteLine("первая матрица:");
PrintMatrix(matrixA);
Console.WriteLine("вторая матрица: ");
PrintMatrix(matrixB);

int rowsA = matrixA.GetLength(0);
int columnsA = matrixA.GetLength(1);
int rowsB = matrixB.GetLength(0);
int columnsB = matrixB.GetLength(1);

if (columnsA != rowsB)
{
    Console.WriteLine("Умножение матриц невозможно: неправильные размерности.");
}
else
{
    int[,] productMatrix = new int[rowsA, columnsB];

    for (int i = 0; i < rowsA; i++)
    {
        for (int j = 0; j < columnsB; j++)
        {
            int sum = 0;
            for (int k = 0; k < columnsA; k++)
            {
                sum += matrixA[i, k] * matrixB[k, j];
            }
            productMatrix[i, j] = sum;
        }
    }
    Console.WriteLine("Результирующая матрица: ");
    PrintMatrix(productMatrix);
}
