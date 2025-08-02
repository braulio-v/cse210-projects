using System;
using System.Collections.Generic;
using System.Diagnostics;

public class Fraction
{
    private int _top;
    private int _bottom;
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;

    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;

    }
    public void SetTop(int Tn)
    {
        _top = Tn;
    }
    
    public int GetTop()
    {
        return _top;
    }

    public void SetBottom(int Bn)
    {
        _bottom = Bn;
    }

    public int GetBottom()
    {
        return _bottom;
    }
    public string GetFractionString()
    {
        string fract = $"{_top}/{_bottom}";
        return fract;

        // or you could do is better:  return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}