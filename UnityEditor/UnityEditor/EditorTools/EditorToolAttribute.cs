using System;
using System.Collections;
using System.Collections.Generic;
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
