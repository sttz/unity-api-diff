using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.UIElements
{

public static class BindingExtensions
{
    static public string prefabOverrideUssClassName;

    static public void Bind(UIElements.VisualElement element, UnityEditor.SerializedObject obj);
    static public UnityEditor.SerializedProperty BindProperty(UIElements.IBindable field, UnityEditor.SerializedObject obj);
    static public void BindProperty(UIElements.IBindable field, UnityEditor.SerializedProperty property);
    static public void TrackPropertyValue(UIElements.VisualElement element, UnityEditor.SerializedProperty property, Action<UnityEditor.SerializedProperty> callback = null);
    static public void Unbind(UIElements.VisualElement element);

}

}
