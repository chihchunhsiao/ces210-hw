using System;

public abstract class Shape
{
    private string _color;

    // public Shape()
    // {

    // }

    public Shape(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    // public virtual double GetArea()
    // {
    //     return -0.01;
    // }

    public abstract double GetArea();
}