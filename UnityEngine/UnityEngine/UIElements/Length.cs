using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public struct Length : IEquatable<UIElements.Length>
{
    static public UIElements.Length Percent(float value);

    public UIElements.LengthUnit unit { get; set; }
    public float value { get; set; }

    public Length(float value);
    public Length(float value, UIElements.LengthUnit unit);

    public bool Equals(UIElements.Length other);
    public bool Equals(object obj);
    public int GetHashCode();
    public string ToString();

}

}
