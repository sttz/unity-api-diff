using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public struct StyleFont : UIElements.IStyleValue<Font>, IEquatable<UIElements.StyleFont>
{
    public UIElements.StyleKeyword keyword { get; set; }
    public Font value { get; set; }

    public StyleFont(Font v);
    public StyleFont(UIElements.StyleKeyword keyword);

    public bool Equals(UIElements.StyleFont other);
    public bool Equals(object obj);
    public int GetHashCode();
    public string ToString();

}

}
