using System;
using UnityEngine;

namespace UnityEditor
{

public struct UndoPropertyModification
{
    public UnityEditor.PropertyModification currentValue;
    public UnityEditor.PropertyModification previousValue;

    public bool keepPrefabOverride { get; set; }

}

}
