﻿/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int SetNumber(string message)
{
    Console.Write(message);
    string arrLength = Console.ReadLine();
    int result = int.Parse(arrLength);
    return result;
}

int[,] GetRandArray(int row, int colums, int minValue = 0, int maxValue = 10)
{
    int[,] matrix = new int[row, colums];
     for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return matrix;   
}

void PrintArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++) //matrix.GetLength(0) - кол-во строк в массиве
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //matrix.GetLength(1) - кол-во столбцов в массиве
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] MultiplicationMatrix(int[,] matr1, int[,] matr2)
{
    int row = Math.Max(matr1.GetLength(0), matr2.GetLength(0));
    int col = Math.Max(matr1.GetLength(1), matr2.GetLength(1));
    int[,] resMatrix = new int[row, col];
    int[] rowArray = new int[matr1.GetLength(1)];
    int[] colArray = new int[matr2.GetLength(0)];
     for(int i = 0; i < resMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resMatrix.GetLength(1); j++)
        {
            for(int k = 0; k < matr1.GetLength(1); k++)
            {
                rowArray[k] = matr1[i,k];
            }                       
            for(int l = 0; l < matr2.GetLength(0); l++)
            {
                colArray[l] = matr2[l,j];
            } 
            int result = 0;
            for(int m = 0; m < col; m++)
            {
                int temp = rowArray[m] * colArray[m];
                result += temp;
            } 
            resMatrix[i, j] = result;
        }
    }
    return resMatrix;
}

bool CheckMatrixes(int row, int col)
{
    if(col != row)
    {
        Console.WriteLine("Умножение матриц не возможно.");
        Console.WriteLine("Две матрицы можно перемножить между собой тогда и только тогда,");
        Console.WriteLine(" когда количество столбцов первой матрицы равно количеству строк второй матрицы.");
        
        
        return true;
    }
    return false;
}


bool checkArray;
int row1;
int col1;
int row2;
int col2;
do
{

row1 = SetNumber("Введите количество строк первой матрицы: ");
col1 = SetNumber("Введите количество столбцов первой матрицы: ");
row2 = SetNumber("Введите количество строк второй матрицы: ");
col2 = SetNumber("Введите количество столбцов второй матрицы: ");
    checkArray = CheckMatrixes(row2, col1);
}
while(checkArray == true);

int[,] martix1 = GetRandArray(row1, col1);
int[,] martix2 = GetRandArray(row2, col2);

// int[,] martix1 = new int[,] {{1,2}, {3,4}};
// int[,] martix2 = new int[,] {{5,6}, {7,8}};
PrintArray(martix1);
Console.WriteLine();
PrintArray(martix2);
Console.WriteLine();
int[,] matrix3 = MultiplicationMatrix(martix1, martix2);
PrintArray(matrix3);