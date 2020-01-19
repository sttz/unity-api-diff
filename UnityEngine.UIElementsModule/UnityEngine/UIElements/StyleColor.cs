using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public struct StyleColor : UIElements.IStyleValue<Color>, IEquatable<UIElements.StyleColor>
{
    public UIElements.StyleKeyword keyword { get; set; }
    public Color value { get; set; }

    public StyleColor(UIElements.StyleKeyword keyword);
    public StyleColor(Color v);

    public bool Equals(object obj);
    public bool Equals(UIElements.StyleColor other);
    public int GetHashCode();
    public string ToString();

}

}
