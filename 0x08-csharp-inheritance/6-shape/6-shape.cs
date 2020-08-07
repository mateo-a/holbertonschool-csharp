using System;

/// <summary>
/// Class: Shape
/// </summary>
class Shape
{
    /// <summary>
    /// Throws an NotImplementedException with the message Area() is not implemented
    /// </summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// Class: Rectangle
/// </summary>
class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>
    /// get: retrieve width
    /// set: if value is negative, throw an ArgumentException with the message Width must be greater than or equal to 0. Otherwise, set width to the value.
    /// </summary>
    /// <value></value>
    public int Width
    {
        get { return (width); }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            else
                width = value;
        }
    }
    /// <summary>
    /// get: retrieve height
    /// set: if value is negative, throw an ArgumentException with the message Height must be greater than or equal to 0. Otherwise, set Height to the value.
    /// </summary>
    public int Height
    {
        get { return (height); }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            else
                height = value;
        }
    }
}
