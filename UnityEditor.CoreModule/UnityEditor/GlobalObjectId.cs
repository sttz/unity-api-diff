using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public struct GlobalObjectId : IEquatable<UnityEditor.GlobalObjectId>
{
    static public UnityEditor.GlobalObjectId GetGlobalObjectIdSlow(int instanceId);
    static public UnityEditor.GlobalObjectId GetGlobalObjectIdSlow(Object targetObject);
    static public void GetGlobalObjectIdsSlow(int[] instanceIds, out UnityEditor.GlobalObjectId[] outputIdentifiers);
    static public void GetGlobalObjectIdsSlow(Object[] objects, out UnityEditor.GlobalObjectId[] outputIdentifiers);
    static public void GlobalObjectIdentifiersToInstanceIDsSlow(UnityEditor.GlobalObjectId[] identifiers, out int[] outputInstanceIDs);
    static public void GlobalObjectIdentifiersToObjectsSlow(UnityEditor.GlobalObjectId[] identifiers, out Object[] outputObjects);
    static public int GlobalObjectIdentifierToInstanceIDSlow(UnityEditor.GlobalObjectId id);
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
