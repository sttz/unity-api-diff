using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class Gradient : IEquatable<Gradient>
{
    public GradientAlphaKey[] alphaKeys { get; set; }
    public GradientColorKey[] colorKeys { get; set; }
    public GradientMode mode { get; set; }

    public Gradient();

    public bool Equals(object o);
    public bool Equals(Gradient other);
    public Color Evaluate(float time);
    public int GetHashCode();
    public void SetKeys(GradientColorKey[] colorKeys, GradientAlphaKey[] alphaKeys);

}

}
