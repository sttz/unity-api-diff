using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal
{

public class MinMaxCurvePropertyDrawer : UnityEditor.PropertyDrawer
{
    public MinMaxCurvePropertyDrawer();

    public void OnGUI(Rect position, UnityEditor.SerializedProperty property, GUIContent label);

}

}
