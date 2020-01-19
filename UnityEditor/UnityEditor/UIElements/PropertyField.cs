using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class PropertyField : UIElements.VisualElement, UIElements.IBindable
{
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string ussClassName;

    public UIElements.IBinding binding { get; set; }
    public string bindingPath { get; set; }
    public string label { get; set; }

    public PropertyField();
    public PropertyField(UnityEditor.SerializedProperty property);
    public PropertyField(UnityEditor.SerializedProperty property, string label);

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.PropertyField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public UxmlTraits();

        public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

    }

}

}
