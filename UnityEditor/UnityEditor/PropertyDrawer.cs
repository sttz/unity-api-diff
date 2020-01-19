using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public abstract class PropertyDrawer : UnityEditor.GUIDrawer
{
    public PropertyAttribute attribute { get; }
    public System.Reflection.FieldInfo fieldInfo { get; }

    protected PropertyDrawer();

    public bool CanCacheInspectorGUI(UnityEditor.SerializedProperty property);
    public float GetPropertyHeight(UnityEditor.SerializedProperty property, GUIContent label);
    public void OnGUI(Rect position, UnityEditor.SerializedProperty property, GUIContent label);

}

}
