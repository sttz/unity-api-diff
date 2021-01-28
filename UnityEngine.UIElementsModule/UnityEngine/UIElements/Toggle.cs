using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class Toggle : UIElements.BaseBoolField
{
    static public string checkmarkUssClassName;
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string noTextVariantUssClassName;
    static public string textUssClassName;
    static public string ussClassName;

    public Toggle();
    public Toggle(string label);

    protected void InitLabel();

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
