using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental
{

public abstract class UIElementsEditor : UnityEditor.Editor
{
    protected UIElementsEditor();

    public Experimental.UIElements.VisualElement CreateInspectorGUI();

}

}
