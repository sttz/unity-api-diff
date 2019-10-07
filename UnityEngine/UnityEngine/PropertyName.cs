using System;
using UnityEngine;

namespace UnityEngine
{

public struct PropertyName : IEquatable<PropertyName>
{
    static public bool IsNullOrEmpty(PropertyName prop);

    public PropertyName(string name);
    public PropertyName(PropertyName other);
    public PropertyName(int id);

    public bool Equals(object other);
    public bool Equals(PropertyName other);
    public int GetHashCode();
    public string ToString();

}

}
