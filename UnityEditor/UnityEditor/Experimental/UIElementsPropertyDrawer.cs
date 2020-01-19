using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental
{

public abstract class UIElementsPropertyDrawer : UnityEditor.PropertyDrawer
{
    protected UIElementsPropertyDrawer();

    public Experimental.UIElements.VisualElement CreatePropertyGUI(UnityEditor.SerializedProperty property);

}

}
