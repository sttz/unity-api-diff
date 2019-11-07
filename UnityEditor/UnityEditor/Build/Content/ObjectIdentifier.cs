using System;
using UnityEngine;

namespace UnityEditor.Build.Content
{

public struct ObjectIdentifier : IEquatable<UnityEditor.Build.Content.ObjectIdentifier>
{
    public string filePath { get; }
    public UnityEditor.Build.Content.FileType fileType { get; }
    public UnityEditor.GUID guid { get; }
    public long localIdentifierInFile { get; }

    public bool Equals(object obj);
    public bool Equals(UnityEditor.Build.Content.ObjectIdentifier other);
    public int GetHashCode();
    public string ToString();

}

}
