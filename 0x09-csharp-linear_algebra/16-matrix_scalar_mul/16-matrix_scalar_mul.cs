using System;

///<summary>Matrix-scalar multiplication</summary>
class MatrixMath
{
    ///<summary>method that multiplies a matrix and a scalar and returns the resulting matrix.</summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] matrixRes;
        double[,] matrixError = new double[,] { { -1 } };

        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
            matrixRes = new double[2, 2];
        else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
            matrixRes = new double[3, 3];
        else
            return (matrixError);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrixRes[i, j] = matrix[i, j] * scalar;
            }
        }
        return (matrixRes);
    }
}
