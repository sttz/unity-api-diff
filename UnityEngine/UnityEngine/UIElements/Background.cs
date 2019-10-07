using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public struct Background : IEquatable<UIElements.Background>
{
    public Texture2D texture { get; set; }

    public Background(Texture2D t);

    public bool Equals(UIElements.Background other);
    public bool Equals(object obj);
    public int GetHashCode();
    public string ToString();

}

}
