using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Media
{

public struct MediaRational
{
    static public UnityEditor.Media.MediaRational Invalid;

    public int denominator;
    public int numerator;

    public UnityEditor.Media.MediaRational inverse { get; }
    public bool isNegative { get; }
    public bool isValid { get; }
    public bool isZero { get; }

    public MediaRational(int numerator);
    public MediaRational(int numerator, int denominator);

    public void Set(int numerator, int denominator = 1);

}

}
