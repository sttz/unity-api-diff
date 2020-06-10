using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Presets
{

public struct PresetType : IEquatable<UnityEditor.Presets.PresetType>
{
    public PresetType(Object o);

    public bool Equals(object obj);
    public bool Equals(UnityEditor.Presets.PresetType other);
    public int GetHashCode();
    public string GetManagedTypeName();
    public bool IsValid();
    public bool IsValidDefault();

}

}
