using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class EnumField : UIElements.BaseField<Enum>
{
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string textUssClassName;
    static public string ussClassName;

    public string text { get; }

    public EnumField();
    public EnumField(Enum defaultValue);
    public EnumField(string label, Enum defaultValue = null);

    protected void ExecuteDefaultActionAtTarget(UIElements.EventBase evt);
    public void Init(Enum defaultValue);
    public void SetValueWithoutNotify(Enum newValue);

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.EnumField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<Enum>
    {
        public UxmlTraits();

        public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

    }

}

}
