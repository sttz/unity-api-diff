using System;
using UnityEngine;

namespace UnityEngine.Assertions.Comparers
{

public class FloatComparer : System.Collections.Generic.IEqualityComparer<float>
{
    static public float kEpsilon = 1E-05;
    static public Assertions.Comparers.FloatComparer s_ComparerWithDefaultTolerance;

    static public bool AreEqual(float expected, float actual, float error);
    static public bool AreEqualRelative(float expected, float actual, float error);

    public FloatComparer();
    public FloatComparer(bool relative);
    public FloatComparer(float error);
    public FloatComparer(float error, bool relative);

    public bool Equals(float a, float b);
    public int GetHashCode(float obj);

}

}
