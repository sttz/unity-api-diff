using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public struct Cursor : IEquatable<UIElements.Cursor>
{
    public Vector2 hotspot { get; set; }
    public Texture2D texture { get; set; }

    public bool Equals(object obj);
    public bool Equals(UIElements.Cursor other);
    public int GetHashCode();
    public string ToString();

}

}
