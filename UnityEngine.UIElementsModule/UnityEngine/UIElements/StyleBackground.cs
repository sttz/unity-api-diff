using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public struct StyleBackground : UIElements.IStyleValue<UIElements.Background>, IEquatable<UIElements.StyleBackground>
{
    public UIElements.StyleKeyword keyword { get; set; }
    public UIElements.Background value { get; set; }

    public StyleBackground(UIElements.StyleKeyword keyword);
    public StyleBackground(Texture2D v);
    public StyleBackground(UIElements.Background v);
    public StyleBackground(UIElements.VectorImage v);

    public bool Equals(object obj);
    public bool Equals(UIElements.StyleBackground other);
    public int GetHashCode();
    public string ToString();

}

}
