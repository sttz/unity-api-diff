using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public struct StyleFont : UIElements.IStyleValue<Font>, IEquatable<UIElements.StyleFont>
{
    public UIElements.StyleKeyword keyword { get; set; }
    public Font value { get; set; }

    public StyleFont(UIElements.StyleKeyword keyword);
    public StyleFont(Font v);

    public bool Equals(object obj);
    public bool Equals(UIElements.StyleFont other);
    public int GetHashCode();
    public string ToString();

}

}
