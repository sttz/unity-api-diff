using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public struct StyleEnum<T> : UIElements.IStyleValue<T>, IEquatable<UIElements.StyleEnum<T>>
{
    public UIElements.StyleKeyword keyword { get; set; }
    public T value { get; set; }

    public StyleEnum(T v);
    public StyleEnum(UIElements.StyleKeyword keyword);

    public bool Equals(UIElements.StyleEnum<T> other);
    public bool Equals(object obj);
    public int GetHashCode();
    public string ToString();

}

}
