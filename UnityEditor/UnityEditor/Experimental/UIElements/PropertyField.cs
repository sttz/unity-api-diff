using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public class PropertyField : Experimental.UIElements.VisualElement, Experimental.UIElements.IBindable
{
    public Experimental.UIElements.IBinding binding { get; set; }
    public string bindingPath { get; set; }
    public string label { get; set; }

    public PropertyField();
    public PropertyField(UnityEditor.SerializedProperty property);
    public PropertyField(UnityEditor.SerializedProperty property, string label);

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<UnityEditor.Experimental.UIElements.PropertyField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public UxmlTraits();

        public void Init(Experimental.UIElements.VisualElement ve, Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

    }

}

}
