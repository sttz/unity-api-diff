using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build.Content
{

public class BuildReferenceMap : System.Runtime.Serialization.ISerializable, IDisposable
{
    public BuildReferenceMap();
    protected BuildReferenceMap(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);

    public void AddMapping(string internalFileName, long serializationIndex, UnityEditor.Build.Content.ObjectIdentifier objectID, bool overwrite = false);
    public void AddMappings(string internalFileName, UnityEditor.Build.Content.SerializationInfo[] objectIDs, bool overwrite = false);
    public void Dispose();
    protected void Dispose(bool disposing);
    public bool Equals(object obj);
    public void FilterToSubset(UnityEditor.Build.Content.ObjectIdentifier[] objectIds);
    public Hash128 GetHash128();
    public int GetHashCode();
    public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);

}

}
