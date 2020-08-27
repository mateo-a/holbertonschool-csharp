using System;

///<summary>Matrix-matrix multiplication</summary>
class MatrixMath
{
    ///<summary>method that multiplies two matrices and returns the resulting matrix.</summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] matrixRes;
        double[,] matrixError = new double[,] { { -1 } };
        double res;

        if (matrix1.GetLength(1) == matrix2.GetLength(0))
            matrixRes = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
        else
            return (matrixError);
        for (int i = 0; i < matrixRes.GetLength(0); i++)
        {
            for (int j = 0; j < matrixRes.GetLength(1); j++)
            {
                res = 0;
                for (int k = 0; k < match; k++)
                {
                    res += matrix1[i, k] * matrix2[k, j];
                }
                matrixRes[i, j] = res;
            }
        }
        return (matrixRes);
    }
}
