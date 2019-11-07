using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public static class UIElementsEntryPoint
{
    static public int GetAntiAliasing(UnityEditor.EditorWindow window);
    static public Experimental.UIElements.VisualElement GetRootVisualContainer(UnityEditor.EditorWindow window);
    static public void SetAntiAliasing(UnityEditor.EditorWindow window, int aa);

}

}
