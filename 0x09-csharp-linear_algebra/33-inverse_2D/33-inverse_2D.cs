using System;

///<summary>Inverse</summary>
class MatrixMath
{
    ///<summary>method that calculates the inverse of a 2D matrix and returns the resulting matrix.</summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        double[,] matrixError = new double[,] { { -1 } };
        double determinant;

        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            determinant = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
            if (determinant == 0)
                return (matrixError);
            double[,] matrixInverse = new double[,] {
                {(1 / determinant) * matrix[1, 1], (1 / determinant) * -matrix[0, 1]},
                {(1 / determinant) * -matrix[1, 0], (1 / determinant) * matrix[0, 0]}
            };
            return (matrixInverse);
        }
        return (matrixError);
    }
}
