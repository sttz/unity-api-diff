using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public struct StyleInt : UIElements.IStyleValue<int>, IEquatable<UIElements.StyleInt>
{
    public UIElements.StyleKeyword keyword { get; set; }
    public int value { get; set; }

    public StyleInt(int v);
    public StyleInt(UIElements.StyleKeyword keyword);

    public bool Equals(UIElements.StyleInt other);
    public bool Equals(object obj);
    public int GetHashCode();
    public string ToString();

}

}
