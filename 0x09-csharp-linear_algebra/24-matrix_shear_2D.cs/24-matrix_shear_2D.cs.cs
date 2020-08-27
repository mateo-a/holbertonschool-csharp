using System;

///<summary>Matrix shear</summary>
class MatrixMath
{
    ///<summary>method that shears a square 2D matrix by a given shear factor and returns the resulting matrix.</summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[,] matrixRes = new double[2, 2];
        double[,] matrixError = new double[,] { { -1 } };
        double[,] matrixTraslate = new double[2, 2] {{1, 0}, {0, 1}};
        double res;

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return (matrixError);
        }
        if (direction == 'x')
            matrixTraslate[1, 0] = factor;
        else if (direction == 'y')
            matrixTraslate[0, 1] = factor;
        else
            return (matrixError);
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                res = 0;
                for (int k = 0; k < 2; k++)
                {
                    res += matrix[i, k] * matrixTraslate[k, j];
                }
                matrixRes[i, j] = Math.Round(res, 2);
            }
        }
        return (matrixRes);
    }
}
