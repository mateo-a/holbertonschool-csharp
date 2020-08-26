using System;

///<summary>Vector addition</summary>
class VectorMath
{
    /// <summary>
    /// Method that adds two vectors and returns the resulting vector.
    /// </summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] vectorRes = new double[1] { -1 };

        if (vector1.Length == vector2.Length)
        {
            if (vector1.Length == 2)
            {
                vector3 = new double[2] { vector1[0] + vector2[0], vector1[1] + vector2[1] };
            }
            if (vector1.Length == 3)
            {
                vector3 = new double[3] { vector1[0] + vector2[0], vector1[1] + vector2[1], vector1[2] + vector2[2] };
            }
            return (vectorRes);
        }
        return (vectorRes);
    }
}
