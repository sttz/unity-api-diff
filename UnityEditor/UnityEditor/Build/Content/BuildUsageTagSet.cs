using System;
using UnityEngine;

namespace UnityEditor.Build.Content
{

public class BuildUsageTagSet : System.Runtime.Serialization.ISerializable, IDisposable
{
    public BuildUsageTagSet();
    protected BuildUsageTagSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);

    public void Dispose();
    protected void Dispose(bool disposing);
    public bool Equals(object obj);
    public Hash128 GetHash128();
    public int GetHashCode();
    public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
    public UnityEditor.Build.Content.ObjectIdentifier[] GetObjectIdentifiers();
    public void UnionWith(UnityEditor.Build.Content.BuildUsageTagSet other);

}

}
