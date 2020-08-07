﻿using System;

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

    /// <summary>
    /// This will override the Area() method defined in the Shape base class.
    /// (Try changing new to override and run the program. What happens?)
    /// </summary>
    /// <returns>The area of the rectangle</returns>
    public new int Area()
    {
        return (width * height);
    }

    /// <summary>
    /// Override To String
    /// </summary>
    /// <returns>"[Rectangle] width / height</returns>
    public override string ToString()
    {
        return ($"[Rectangle] {width} / {height}");
    }
}

/// <summary>
/// Class: Square that inherits from Rectangle 
/// </summary>
class Square : Rectangle
{
    private int size;
    /// <summary>
    /// get: retrieve size
    /// set: if value is negative, throw an ArgumentException with the message Size must be greater than or equal to 0. Otherwise, set size, height, and width to the value.
    /// </summary>
    public int Size
    {
        get { return (size); }
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            size = Width = Height = value;
        }
    }

    /// <summary>
    /// Override To String
    /// </summary>
    /// <returns>[Square] size / size</returns>
    public override string ToString()
    {
        return ($"[Square] {size} / {size}");
    }
}
