using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public struct StyleFontDefinition : UIElements.IStyleValue<UIElements.FontDefinition>, IEquatable<UIElements.StyleFontDefinition>
{
    public UIElements.StyleKeyword keyword { get; set; }
    public UIElements.FontDefinition value { get; set; }

    public StyleFontDefinition(Font f);
    public StyleFontDefinition(UIElements.FontDefinition f);
    public StyleFontDefinition(UIElements.StyleKeyword keyword);

    public bool Equals(object obj);
    public bool Equals(UIElements.StyleFontDefinition other);
    public int GetHashCode();

}

}
