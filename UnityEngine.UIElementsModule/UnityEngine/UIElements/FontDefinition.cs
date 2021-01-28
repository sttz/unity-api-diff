using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public struct FontDefinition : IEquatable<UIElements.FontDefinition>
{
    static public UIElements.FontDefinition FromFont(Font f);
    static public UIElements.FontDefinition FromSDFFont(Object f);

    public Font font { get; set; }
    public Object fontAsset { get; set; }

    public bool Equals(object obj);
    public bool Equals(UIElements.FontDefinition other);
    public int GetHashCode();
    public string ToString();

}

}
