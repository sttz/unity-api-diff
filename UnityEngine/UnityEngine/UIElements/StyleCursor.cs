using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public struct StyleCursor : UIElements.IStyleValue<UIElements.Cursor>, IEquatable<UIElements.StyleCursor>
{
    public UIElements.StyleKeyword keyword { get; set; }
    public UIElements.Cursor value { get; set; }

    public StyleCursor(UIElements.Cursor v);
    public StyleCursor(UIElements.StyleKeyword keyword);

    public bool Equals(UIElements.StyleCursor other);
    public bool Equals(object obj);
    public int GetHashCode();
    public string ToString();

}

}
