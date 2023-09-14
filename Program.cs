﻿

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] / 10 <= 0)
                Console.Write($" {matrix[i, j]} ");

            else Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] GetSpiral(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > matrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return matrix;
}

PrintMatrix(GetSpiral(4, 4));

