using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public struct StyleFloat : UIElements.IStyleValue<float>, IEquatable<UIElements.StyleFloat>
{
    public UIElements.StyleKeyword keyword { get; set; }
    public float value { get; set; }

    public StyleFloat(float v);
    public StyleFloat(UIElements.StyleKeyword keyword);

    public bool Equals(UIElements.StyleFloat other);
    public bool Equals(object obj);
    public int GetHashCode();
    public string ToString();

}

}
