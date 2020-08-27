using System;

///<summary>Dot product</summary>
class VectorMath
{
    ///<summary>method that calculates dot product of either two 2D or two 3D vectors.</summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        double res = 0;

        if (vector1.Length == vector2.Length)
        {
            if (vector1.Length == 2 || vector1.Length == 3)
            {
                for (int i = 0; i < vector1.Length; i++)
                    res += (vector1[i] * vector2[i]);
                return (res);
            }
            return (res - 1);
        }
        return (res - 1);
    }
}
