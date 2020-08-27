using System;
using System.Collections.Generic;

///<summary>Cross product</summary>
class VectorMath
{
    ///<summary>method that calculates the cross product of two 3D vectors and returns the resulting vector.</summary>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        double[] vectorRes;

        if (vector1.Length == 3 && vector2.Length == 3)
        {
            vectorRes = new double[3] {(vector1[1] * vector2[2]) - (vector1[2] * vector2[1]),
                                        (vector1[2] * vector2[0]) - (vector1[0] * vector2[2]),
                                        (vector1[0] * vector2[1]) - (vector1[1] * vector2[0])
            };
            return (vectorRes);
        }
        return (new double[] { -1 });
    }
}
