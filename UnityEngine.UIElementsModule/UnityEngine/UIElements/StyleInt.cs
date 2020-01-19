using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public struct StyleInt : UIElements.IStyleValue<int>, IEquatable<UIElements.StyleInt>
{
    public UIElements.StyleKeyword keyword { get; set; }
    public int value { get; set; }

    public StyleInt(UIElements.StyleKeyword keyword);
    public StyleInt(int v);

    public bool Equals(object obj);
    public bool Equals(UIElements.StyleInt other);
    public int GetHashCode();
    public string ToString();

}

}
