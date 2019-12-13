using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public struct VisualElementStyleSheetSet : IEquatable<UIElements.VisualElementStyleSheetSet>
{
    public int count { get; }
    public UIElements.StyleSheet this[int index] { get; }

    public void Add(UIElements.StyleSheet styleSheet);
    public void Clear();
    public bool Contains(UIElements.StyleSheet styleSheet);
    public bool Equals(UIElements.VisualElementStyleSheetSet other);
    public bool Equals(object obj);
    public int GetHashCode();
    public bool Remove(UIElements.StyleSheet styleSheet);

}

}