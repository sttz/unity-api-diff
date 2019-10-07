using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class Toggle : UIElements.BaseField<bool>
{
    static public string checkmarkUssClassName;
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string noTextVariantUssClassName;
    static public string textUssClassName;
    static public string ussClassName;

    public string text { get; set; }

    public Toggle();
    public Toggle(string label);

    protected void ExecuteDefaultActionAtTarget(UIElements.EventBase evt);
    public void SetValueWithoutNotify(bool newValue);

    public class UxmlFactory : UIElements.UxmlFactory<UIElements.Toggle, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UIElements.BaseFieldTraits<bool, UIElements.UxmlBoolAttributeDescription>
    {
        public UxmlTraits();

        public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

    }

}

}
