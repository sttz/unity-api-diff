using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public struct StyleTextShadow : UIElements.IStyleValue<UIElements.TextShadow>, IEquatable<UIElements.StyleTextShadow>
{
    public UIElements.StyleKeyword keyword { get; set; }
    public UIElements.TextShadow value { get; set; }

    public StyleTextShadow(UIElements.StyleKeyword keyword);
    public StyleTextShadow(UIElements.TextShadow v);

    public bool Equals(object obj);
    public bool Equals(UIElements.StyleTextShadow other);
    public int GetHashCode();
    public string ToString();

}

}
