using System;
using UnityEngine;

namespace UnityEditor
{

public struct GlobalObjectId : IEquatable<UnityEditor.GlobalObjectId>
{
    static public UnityEditor.GlobalObjectId GetGlobalObjectIdSlow(Object targetObject);
    static public void GetGlobalObjectIdsSlow(Object[] objects, out UnityEditor.GlobalObjectId[] outputIdentifiers);
    static public void GlobalObjectIdentifiersToObjectsSlow(UnityEditor.GlobalObjectId[] identifiers, out Object[] outputObjects);
    static public Object GlobalObjectIdentifierToObjectSlow(UnityEditor.GlobalObjectId id);
    static public bool TryParse(string stringValue, out UnityEditor.GlobalObjectId id);

    public UnityEditor.GUID assetGUID { get; }
    public int identifierType { get; }
    public ulong targetObjectId { get; }
    public ulong targetPrefabId { get; }

    public bool Equals(UnityEditor.GlobalObjectId other);
    public string ToString();

}

}
