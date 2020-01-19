using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class CustomEditor : Attribute
{
    public bool isFallback { get; set; }

    public CustomEditor(Type inspectedType);
    public CustomEditor(Type inspectedType, bool editorForChildClasses);

}

}
