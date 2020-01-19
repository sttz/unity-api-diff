using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class Vector4Field : UnityEditor.UIElements.BaseCompositeField<Vector4, UnityEditor.UIElements.FloatField, float>
{
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string ussClassName;

    public Vector4Field();
    public Vector4Field(string label);

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.Vector4Field, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<Vector4>
    {
        public UxmlTraits();

        public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

    }

}

}
