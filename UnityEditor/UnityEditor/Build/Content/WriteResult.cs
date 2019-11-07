using System;
using UnityEngine;

namespace UnityEditor.Build.Content
{

public struct WriteResult
{
    public System.Collections.ObjectModel.ReadOnlyCollection<Type> includedTypes { get; }
    public System.Collections.ObjectModel.ReadOnlyCollection<UnityEditor.Build.Content.ResourceFile> resourceFiles { get; }
    public System.Collections.ObjectModel.ReadOnlyCollection<UnityEditor.Build.Content.ObjectSerializedInfo> serializedObjects { get; }

}

}
