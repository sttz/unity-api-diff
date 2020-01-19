using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class BoundsField : UIElements.BaseField<Bounds>
{
    static public string centerFieldUssClassName;
    static public string extentsFieldUssClassName;
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string ussClassName;

    public BoundsField();
    public BoundsField(string label);

    public void SetValueWithoutNotify(Bounds newValue);

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.BoundsField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<Bounds>
    {
        public UxmlTraits();

        public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

    }

}

}
