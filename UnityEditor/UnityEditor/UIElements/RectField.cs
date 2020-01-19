using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class RectField : UnityEditor.UIElements.BaseCompositeField<Rect, UnityEditor.UIElements.FloatField, float>
{
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string ussClassName;

    public RectField();
    public RectField(string label);

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.RectField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<Rect>
    {
        public UxmlTraits();

        public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

    }

}

}
