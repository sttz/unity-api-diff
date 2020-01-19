using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public struct CursorStyle : IEquatable<Experimental.UIElements.CursorStyle>
{
    public Vector2 hotspot { get; set; }
    public Texture2D texture { get; set; }

    public bool Equals(object obj);
    public bool Equals(Experimental.UIElements.CursorStyle other);
    public int GetHashCode();

}

}
