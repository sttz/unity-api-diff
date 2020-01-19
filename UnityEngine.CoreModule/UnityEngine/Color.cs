using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct Color : IEquatable<Color>
{
    static public Color black { get; }
    static public Color blue { get; }
    static public Color clear { get; }
    static public Color cyan { get; }
    static public Color gray { get; }
    static public Color green { get; }
    static public Color grey { get; }
    static public Color magenta { get; }
    static public Color red { get; }
    static public Color white { get; }
    static public Color yellow { get; }

    static public Color HSVToRGB(float H, float S, float V);
    static public Color HSVToRGB(float H, float S, float V, bool hdr);
    static public Color Lerp(Color a, Color b, float t);
    static public Color LerpUnclamped(Color a, Color b, float t);
    static public void RGBToHSV(Color rgbColor, out float H, out float S, out float V);

    public float a;
    public float b;
    public float g;
    public float r;

    public Color gamma { get; }
    public float grayscale { get; }
    public float this[int index] { get; set; }
    public Color linear { get; }
    public float maxColorComponent { get; }

    public Color(float r, float g, float b);
    public Color(float r, float g, float b, float a);

    public bool Equals(object other);
    public bool Equals(Color other);
    public int GetHashCode();
    public string ToString();
    public string ToString(string format);

}

}
