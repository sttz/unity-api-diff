using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public struct CustomStyleProperty<T> : IEquatable<UIElements.CustomStyleProperty<T>>
{
    public string name { get; private set; }

    public CustomStyleProperty(string propertyName);

    public bool Equals(object obj);
    public bool Equals(UIElements.CustomStyleProperty<T> other);
    public int GetHashCode();

}

}
