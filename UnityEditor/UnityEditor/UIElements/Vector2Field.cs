using System;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class Vector2Field : UnityEditor.UIElements.BaseCompositeField<Vector2, UnityEditor.UIElements.FloatField, float>
{
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string ussClassName;

    public Vector2Field();
    public Vector2Field(string label);

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.Vector2Field, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<Vector2>
    {
        public UxmlTraits();

        public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

    }

}

}
