using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public struct StyleLength : UIElements.IStyleValue<UIElements.Length>, IEquatable<UIElements.StyleLength>
{
    public UIElements.StyleKeyword keyword { get; set; }
    public UIElements.Length value { get; set; }

    public StyleLength(UIElements.StyleKeyword keyword);
    public StyleLength(float v);
    public StyleLength(UIElements.Length v);

    public bool Equals(object obj);
    public bool Equals(UIElements.StyleLength other);
    public int GetHashCode();
    public string ToString();

}

}
