using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class RadioButton : UIElements.BaseBoolField, UIElements.IGroupBoxOption
{
    static public string checkmarkBackgroundUssClassName;
    static public string checkmarkUssClassName;
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string textUssClassName;
    static public string ussClassName;

    public bool value { get; set; }

    public RadioButton();
    public RadioButton(string label);

    protected void InitLabel();
    public void SetSelected(bool selected);
    public void SetValueWithoutNotify(bool newValue);
    protected void ToggleValue();
    protected void UpdateMixedValueContent();

    public class UxmlFactory : UIElements.UxmlFactory<UIElements.RadioButton, UxmlTraits>
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
