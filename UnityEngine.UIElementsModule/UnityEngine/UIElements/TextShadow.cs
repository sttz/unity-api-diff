using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public struct TextShadow : IEquatable<UIElements.TextShadow>
{
    public float blurRadius;
    public Color color;
    public Vector2 offset;

    public bool Equals(object obj);
    public bool Equals(UIElements.TextShadow other);
    public int GetHashCode();
    public string ToString();

}

}
