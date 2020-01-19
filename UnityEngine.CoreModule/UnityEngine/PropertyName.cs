using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct PropertyName : IEquatable<PropertyName>
{
    static public bool IsNullOrEmpty(PropertyName prop);

    public PropertyName(int id);
    public PropertyName(string name);
    public PropertyName(PropertyName other);

    public bool Equals(object other);
    public bool Equals(PropertyName other);
    public int GetHashCode();
    public string ToString();

}

}
