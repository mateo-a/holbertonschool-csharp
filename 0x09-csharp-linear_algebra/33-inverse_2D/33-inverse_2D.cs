using System;

///<summary>Inverse</summary>
class MatrixMath
{
    ///<summary>method that calculates the inverse of a 2D matrix and returns the resulting matrix.</summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        double[,] matrixError = new double[,] { { -1 } };

        if (matrix == null || matrix.GetLength(0) != 2 || matrix.GetLength(0) != matrix.GetLength(1))
            return (matrixError);

        double res = matrix[1, 1];

        matrix[1, 1] = matrix[0, 0];
        matrix[0, 0] = res;
        matrix[0, 1] *= -1;
        matrix[1, 0] *= -1;

        double determinant = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);

        if (determinant != 0)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = Math.Round(matrix[i, j] / determinant, 2);
            return (matrix);
        }
        return (new double[,] { { -1 } });
    }
}
