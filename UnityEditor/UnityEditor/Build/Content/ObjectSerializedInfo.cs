using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build.Content
{

public struct ObjectSerializedInfo
{
    public UnityEditor.Build.Content.SerializedLocation header { get; }
    public UnityEditor.Build.Content.SerializedLocation rawData { get; }
    public UnityEditor.Build.Content.ObjectIdentifier serializedObject { get; }

}

}
