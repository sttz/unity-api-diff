using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public struct Background : IEquatable<UIElements.Background>
{
    static public UIElements.Background FromTexture2D(Texture2D t);
    static public UIElements.Background FromVectorImage(UIElements.VectorImage vi);

    public Texture2D texture { get; set; }
    public UIElements.VectorImage vectorImage { get; set; }

    public Background(Texture2D t);

    public bool Equals(object obj);
    public bool Equals(UIElements.Background other);
    public int GetHashCode();
    public string ToString();

}

}
