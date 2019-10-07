using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public struct StyleBackground : UIElements.IStyleValue<UIElements.Background>, IEquatable<UIElements.StyleBackground>
{
    public UIElements.StyleKeyword keyword { get; set; }
    public UIElements.Background value { get; set; }

    public StyleBackground(UIElements.Background v);
    public StyleBackground(Texture2D v);
    public StyleBackground(UIElements.StyleKeyword keyword);

    public bool Equals(UIElements.StyleBackground other);
    public bool Equals(object obj);
    public int GetHashCode();
    public string ToString();

}

}
