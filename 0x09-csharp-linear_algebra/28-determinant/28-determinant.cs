﻿using System;

///<summary>Determinant </summary>
class MatrixMath
{
    ///<summary>method that calculates the determinant of a matrix.</summary>
    public static double Determinant(double[,] matrix)
    {
        double determinant = 0;

        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
            determinant = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
        else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
        {
            determinant = (matrix[0, 0] * matrix[1, 1] * matrix[2, 2]) +
                        (matrix[1, 0] * matrix[2, 1] * matrix[0, 2]) +
                        (matrix[2, 0] * matrix[0, 1] * matrix[1, 2]) -
                        (matrix[0, 0] * matrix[2, 1] * matrix[1, 2]) -
                        (matrix[2, 0] * matrix[1, 1] * matrix[0, 2]) -
                        (matrix[1, 0] * matrix[0, 1] * matrix[2, 2]);
        }
        else
            return -1;
        return (Math.Round(determinant, 2));
    }
}
