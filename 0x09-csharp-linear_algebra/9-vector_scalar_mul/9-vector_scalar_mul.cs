using System;

///<summary>Vector-scalar multiplication</summary>
class VectorMath
{
    ///<summary>method that multiplies a vector and a scalar and returns the resulting vector.</summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] vetorRes = new double[1] { -1 };

        if (vector.Length == 2)
        {
            vetorRes = new double[2] { vector[0] * scalar, vector[1] * scalar };
        }
        if (vector.Length == 3)
        {
            vetorRes = new double[3] { vector[0] * scalar, vector[1] * scalar, vector[2] * scalar };
        }
        return (vetorRes);
    }
}
