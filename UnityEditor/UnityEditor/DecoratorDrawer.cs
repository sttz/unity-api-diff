using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public abstract class DecoratorDrawer : UnityEditor.GUIDrawer
{
    public PropertyAttribute attribute { get; }

    protected DecoratorDrawer();

    public bool CanCacheInspectorGUI();
    public float GetHeight();
    public void OnGUI(Rect position);

}

}
