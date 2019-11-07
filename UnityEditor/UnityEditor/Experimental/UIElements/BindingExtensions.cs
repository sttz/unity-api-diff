using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public static class BindingExtensions
{
    static public void Bind(Experimental.UIElements.VisualElement element, UnityEditor.SerializedObject obj);
    static public UnityEditor.SerializedProperty BindProperty(Experimental.UIElements.IBindable field, UnityEditor.SerializedObject obj);
    static public void BindProperty(Experimental.UIElements.IBindable field, UnityEditor.SerializedProperty property);
    static public void Unbind(Experimental.UIElements.VisualElement element);

}

}
