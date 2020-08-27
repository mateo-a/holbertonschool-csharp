using System;

///<summary> Transpose matrix</summary>
class MatrixMath
{
    ///<summary>method to transpose a matrix and return the resulting matrix.</summary>
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] matrixRes = new double[matrix.GetLength(1), matrix.GetLength(0)];

        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                matrixRes[i, j] = matrix[j, i];
            }
        }
        return (matrixRes);
    }
}
