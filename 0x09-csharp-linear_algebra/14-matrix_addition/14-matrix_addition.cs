﻿using System;

/// <summary>Matrix addition</summary>
class MatrixMath
{
    /// <summary>method that adds two matrices and returns the resulting matrix.</summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] matrixRes;
        double[,] matrixError = new double[,] { { -1 } };

        if ((matrix1.GetLength(0) == matrix2.GetLength(0)) && (matrix1.GetLength(1) == matrix2.GetLength(1)) && (matrix1.GetLength(0) == 2) && (matrix1.GetLength(1) == 2))
            matrixRes = new double[2, 2];
        else if ((matrix1.GetLength(0) == matrix2.GetLength(0)) && (matrix1.GetLength(1) == matrix2.GetLength(1)) && (matrix1.GetLength(0) == 3) && (matrix1.GetLength(1) == 3))
            matrixRes = new double[3, 3];
        else
            return (matrixError);
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                matrixRes[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return matrixRes;
    }
}
