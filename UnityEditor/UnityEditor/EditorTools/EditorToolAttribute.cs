using System;
using UnityEngine;

namespace UnityEditor.EditorTools
{

public sealed class EditorToolAttribute : Attribute
{
    public string displayName { get; private set; }
    public Type targetType { get; set; }

    public EditorToolAttribute(string displayName, Type targetType = null);

}

}
