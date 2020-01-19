using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public struct Length : IEquatable<UIElements.Length>
{
    public UIElements.LengthUnit unit { get; set; }
    public float value { get; set; }

    public Length(float value);
    public Length(float value, UIElements.LengthUnit unit);

    public bool Equals(object obj);
    public bool Equals(UIElements.Length other);
    public int GetHashCode();
    public string ToString();

}

}
