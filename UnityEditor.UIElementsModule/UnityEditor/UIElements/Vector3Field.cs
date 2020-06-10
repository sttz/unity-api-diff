using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class Vector3Field : UnityEditor.UIElements.BaseCompositeField<Vector3, UnityEditor.UIElements.FloatField, float>
{
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string ussClassName;

    public Vector3Field();
    public Vector3Field(string label);

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.Vector3Field, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<Vector3>
    {
        public UxmlTraits();

        public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

    }

}

}
