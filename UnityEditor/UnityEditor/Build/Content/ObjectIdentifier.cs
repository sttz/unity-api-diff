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

    public string filePath { get; internal set; }
    public UnityEditor.Build.Content.FileType fileType { get; internal set; }
    public UnityEditor.GUID guid { get; internal set; }
    public long localIdentifierInFile { get; internal set; }

    public bool Equals(object obj);
    public bool Equals(UnityEditor.Build.Content.ObjectIdentifier other);
    public int GetHashCode();
    public string ToString();

}

}
