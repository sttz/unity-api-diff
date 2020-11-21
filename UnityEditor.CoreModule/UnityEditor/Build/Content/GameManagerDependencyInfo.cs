using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build.Content
{

public struct GameManagerDependencyInfo
{
    public System.Collections.ObjectModel.ReadOnlyCollection<Type> includedTypes { get; }
    public System.Collections.ObjectModel.ReadOnlyCollection<UnityEditor.Build.Content.ObjectIdentifier> managerObjects { get; }
    public System.Collections.ObjectModel.ReadOnlyCollection<UnityEditor.Build.Content.ObjectIdentifier> referencedObjects { get; }

}

}
