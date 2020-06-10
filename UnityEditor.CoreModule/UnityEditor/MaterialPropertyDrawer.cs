using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public abstract class MaterialPropertyDrawer
{
    protected MaterialPropertyDrawer();

    public void Apply(UnityEditor.MaterialProperty prop);
    public float GetPropertyHeight(UnityEditor.MaterialProperty prop, string label, UnityEditor.MaterialEditor editor);
    public void OnGUI(Rect position, UnityEditor.MaterialProperty prop, string label, UnityEditor.MaterialEditor editor);
    public void OnGUI(Rect position, UnityEditor.MaterialProperty prop, GUIContent label, UnityEditor.MaterialEditor editor);

}

}
