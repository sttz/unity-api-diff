using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public struct StyleCursor : UIElements.IStyleValue<UIElements.Cursor>, IEquatable<UIElements.StyleCursor>
{
    public UIElements.StyleKeyword keyword { get; set; }
    public UIElements.Cursor value { get; set; }

    public StyleCursor(UIElements.StyleKeyword keyword);
    public StyleCursor(UIElements.Cursor v);

    public bool Equals(object obj);
    public bool Equals(UIElements.StyleCursor other);
    public int GetHashCode();
    public string ToString();

}

}
