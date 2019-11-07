using System;
using UnityEngine;

namespace UnityEditor
{

public struct GUID : IComparable, IComparable<UnityEditor.GUID>, IEquatable<UnityEditor.GUID>
{
    static public UnityEditor.GUID Generate();
    static public bool TryParse(string hex, out UnityEditor.GUID result);

    public GUID(string hexRepresentation);

    public int CompareTo(object obj);
    public int CompareTo(UnityEditor.GUID rhs);
    public bool Empty();
    public bool Equals(object obj);
    public bool Equals(UnityEditor.GUID obj);
    public int GetHashCode();
    public bool ParseExact(string hex);
    public string ToString();

}

}
