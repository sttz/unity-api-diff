using System;
using UnityEngine;

namespace UnityEngine.Internal
{

public class DefaultValueAttribute : Attribute
{
    public object Value { get; }

    public DefaultValueAttribute(string value);

    public bool Equals(object obj);
    public int GetHashCode();

}

}
