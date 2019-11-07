using System;
using UnityEngine;

namespace UnityEngine
{

public class RectOffset : IFormattable
{
    public int bottom { get; set; }
    public int horizontal { get; }
    public int left { get; set; }
    public int right { get; set; }
    public int top { get; set; }
    public int vertical { get; }

    public RectOffset();
    public RectOffset(int left, int right, int top, int bottom);

    public Rect Add(Rect rect);
    public Rect Remove(Rect rect);
    public string ToString();
    public string ToString(string format);
    public string ToString(string format, IFormatProvider formatProvider);

}

}
