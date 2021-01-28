using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class DropdownField : UIElements.BaseField<string>
{
    public int index { get; set; }
    public string text { get; }
    protected UIElements.TextElement textElement { get; }
    public string value { get; set; }

    public DropdownField();
    public DropdownField(string label);
    public DropdownField(List<string> choices, int defaultIndex, Func<string, string> formatSelectedValueCallback = null, Func<string, string> formatListItemCallback = null);
    public DropdownField(List<string> choices, string defaultValue, Func<string, string> formatSelectedValueCallback = null, Func<string, string> formatListItemCallback = null);
    public DropdownField(string label, List<string> choices, int defaultIndex, Func<string, string> formatSelectedValueCallback = null, Func<string, string> formatListItemCallback = null);
    public DropdownField(string label, List<string> choices, string defaultValue, Func<string, string> formatSelectedValueCallback = null, Func<string, string> formatListItemCallback = null);

    protected void ExecuteDefaultActionAtTarget(UIElements.EventBase evt);
    public void SetValueWithoutNotify(string newValue);
    protected void UpdateMixedValueContent();

    public class UxmlFactory : UIElements.UxmlFactory<UIElements.DropdownField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<string>
    {
        public UxmlTraits();

        public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

    }

}

}
