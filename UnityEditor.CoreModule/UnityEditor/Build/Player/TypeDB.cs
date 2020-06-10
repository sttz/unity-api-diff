using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build.Player
{

public class TypeDB : System.Runtime.Serialization.ISerializable, IDisposable
{
    protected TypeDB(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);

    public void Dispose();
    protected void Dispose(bool disposing);
    public bool Equals(object obj);
    public Hash128 GetHash128();
    public int GetHashCode();
    public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);

}

}
