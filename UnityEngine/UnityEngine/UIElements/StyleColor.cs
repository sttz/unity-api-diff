using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public struct StyleColor : UIElements.IStyleValue<Color>, IEquatable<UIElements.StyleColor>
{
    public UIElements.StyleKeyword keyword { get; set; }
    public Color value { get; set; }

    public StyleColor(Color v);
    public StyleColor(UIElements.StyleKeyword keyword);

    public bool Equals(UIElements.StyleColor other);
    public bool Equals(object obj);
    public int GetHashCode();
    public string ToString();

}

}
