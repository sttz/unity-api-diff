using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal
{

public class MinMaxGradientPropertyDrawer : UnityEditor.PropertyDrawer
{
    public MinMaxGradientPropertyDrawer();

    public float GetPropertyHeight(UnityEditor.SerializedProperty property, GUIContent label);
    public void OnGUI(Rect position, UnityEditor.SerializedProperty property, GUIContent label);

}

}
