using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public struct StyleFloat : UIElements.IStyleValue<float>, IEquatable<UIElements.StyleFloat>
{
    public UIElements.StyleKeyword keyword { get; set; }
    public float value { get; set; }

    public StyleFloat(UIElements.StyleKeyword keyword);
    public StyleFloat(float v);

    public bool Equals(object obj);
    public bool Equals(UIElements.StyleFloat other);
    public int GetHashCode();
    public string ToString();

}

}
