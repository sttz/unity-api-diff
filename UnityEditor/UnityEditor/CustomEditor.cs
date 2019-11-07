using System;
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
