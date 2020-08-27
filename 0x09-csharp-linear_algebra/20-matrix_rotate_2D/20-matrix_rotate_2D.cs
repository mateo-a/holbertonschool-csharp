using System;

///<summary>Matrix rotation </summary>
class MatrixMath
{
    ///<summary>method that rotates a square 2D matrix by a given angle in radians and returns the resulting matrix.</summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double[,] matrixRes = new double[2, 2];
        double[,] matrixError = new double[,] { { -1 } };
        double[,] matrixRotation = new double[2, 2] {{Math.Cos(angle), Math.Sin(angle)},
                                               {-1 * Math.Sin(angle), Math.Cos(angle)}};

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return (matrixError);
        }
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    matrixRes[i, j] = Math.Round(matrixRes[i, j] + matrix[i, k] * matrixRotation[k, j], 2);
                }
            }
        }
        return (matrixRes);
    }
}
