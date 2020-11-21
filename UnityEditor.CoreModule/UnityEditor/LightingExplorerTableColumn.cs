using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public sealed class LightingExplorerTableColumn
{
    public LightingExplorerTableColumn(DataType type, GUIContent headerContent, string propertyName = null, int width = 100, OnGUIDelegate onGUIDelegate = null, ComparePropertiesDelegate compareDelegate = null, CopyPropertiesDelegate copyDelegate = null, int[] dependencyIndices = null);

    public delegate int ComparePropertiesDelegate(UnityEditor.SerializedProperty lhs, UnityEditor.SerializedProperty rhs);

    public delegate void CopyPropertiesDelegate(UnityEditor.SerializedProperty target, UnityEditor.SerializedProperty source);

    public enum DataType
    {
        Name = 0,
        Checkbox = 1,
        Enum = 2,
        Int = 3,
        Float = 4,
        Color = 5,
        Custom = 20,
    }

    public delegate void OnGUIDelegate(Rect r, UnityEditor.SerializedProperty prop, UnityEditor.SerializedProperty[] dependencies);

}

}
