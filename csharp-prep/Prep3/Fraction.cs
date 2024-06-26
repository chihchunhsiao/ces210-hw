using System;
using System.Formats.Asn1;
using System.Runtime.InteropServices;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1 ;
        _bottom = 1 ; 
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber ;
        _bottom = 1 ;
    }

    public Fraction(int top, int bottom)
    {
        _top = top ;
        _bottom = bottom ;
    }

    public int GetTop()
    {
        return _top;
    }


    public int GetBottom()
    {
        return _bottom;
    }


    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        double value = (double)_top / (double)_bottom;
        return value;
    }

}