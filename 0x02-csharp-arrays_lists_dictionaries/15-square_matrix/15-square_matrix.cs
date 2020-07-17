using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int mainCol = myMatrix.GetLength(0);
        int mainRow = myMatrix.GetLength(1);
        int[,] array = new int[mainCol, mainRow];
        for (int col = 0; col < mainCol; col++)
            for (int row = 0; row < mainRow; row++)
                array[col, row] = myMatrix[col, row] * myMatrix[col, row];
        return array;
    }
}
