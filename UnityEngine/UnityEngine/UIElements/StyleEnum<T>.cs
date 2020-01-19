using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public struct StyleEnum<T> : UIElements.IStyleValue<T>, IEquatable<UIElements.StyleEnum<T>>
{
    public UIElements.StyleKeyword keyword { get; set; }
    public T value { get; set; }

    public StyleEnum(UIElements.StyleKeyword keyword);
    public StyleEnum(T v);

    public bool Equals(object obj);
    public bool Equals(UIElements.StyleEnum<T> other);
    public int GetHashCode();
    public string ToString();

}

}
