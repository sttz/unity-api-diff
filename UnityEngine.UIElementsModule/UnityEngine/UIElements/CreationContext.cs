using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public struct CreationContext : IEquatable<UIElements.CreationContext>
{
    static public UIElements.CreationContext Default;

    public Dictionary<string, UIElements.VisualElement> slotInsertionPoints { get; private set; }
    public UIElements.VisualElement target { get; private set; }
    public UIElements.VisualTreeAsset visualTreeAsset { get; private set; }

    public bool Equals(object obj);
    public bool Equals(UIElements.CreationContext other);
    public int GetHashCode();

}

}
