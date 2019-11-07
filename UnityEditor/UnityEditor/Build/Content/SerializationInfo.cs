using System;
using UnityEngine;

namespace UnityEditor.Build.Content
{

public class SerializationInfo
{
    public long serializationIndex { get; set; }
    public UnityEditor.Build.Content.ObjectIdentifier serializationObject { get; set; }

    public SerializationInfo();

}

}
