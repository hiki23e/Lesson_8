/*задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:

2 4 | 3 4
3 2 | 3 3 
Результирующая матрица будет:

18 20
15 18 
*/
using System;

class Program
{
  public static void Main(string[] args)
  {
    int[,] A = {
      {2, 4},
      {3, 2}
    };

    int[,] B = {
      {3, 4},
      {3, 3}
    };

    int rowA = A.GetUpperBound(0) + 1;
    int colA = A.Length / rowA;

    int rowB = B.GetUpperBound(0) + 1;
    int colB = B.Length / rowB;

    int[,] C = new int[rowB, colB];

    if (colA == rowB)
    {
      for (int i = 0; i < rowB; i++)
        for (int l = 0; l < colA; l++)
          for (int j = 0; j < colB; j++)
            C[l, j] += A[l, i] * B[i, j];
    }
    else
    {
      Console.WriteLine($"Такую матрицу перемножать нельзя");
    }

    printArray(A);
    printArray(B);
    printArray(C);
  }

  private static void printArray(int[,] arr)
  {
    Console.WriteLine();

    int row = arr.GetUpperBound(0) + 1;
    int col = arr.Length / row;

    for (int i = 0; i < row; i++)
    {
      for (int j = 0; j < col; j++)
        Console.Write($"{arr[i, j]} ");
      Console.WriteLine();
    }
  }
} 
