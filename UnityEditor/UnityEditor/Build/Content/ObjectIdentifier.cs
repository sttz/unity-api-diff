using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build.Content
{

public struct ObjectIdentifier : IEquatable<UnityEditor.Build.Content.ObjectIdentifier>
{
    static public int ToInstanceID(UnityEditor.Build.Content.ObjectIdentifier objectId);
    static public Object ToObject(UnityEditor.Build.Content.ObjectIdentifier objectId);
    static public bool TryGetObjectIdentifier(int instanceID, out UnityEditor.Build.Content.ObjectIdentifier objectId);
    static public bool TryGetObjectIdentifier(Object targetObject, out UnityEditor.Build.Content.ObjectIdentifier objectId);

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
