using System;
using UnityEngine;

namespace UnityEditor.Experimental
{

public abstract class UIElementsEditor : UnityEditor.Editor
{
    protected UIElementsEditor();

    public Experimental.UIElements.VisualElement CreateInspectorGUI();

}

}
