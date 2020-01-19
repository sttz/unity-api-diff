using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class MaskField : UnityEditor.UIElements.BasePopupField<int, string>
{
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string ussClassName;

    public Func<string, string> formatListItemCallback { get; set; }
    public Func<string, string> formatSelectedValueCallback { get; set; }

    public MaskField();
    public MaskField(string label);
    public MaskField(List<string> choices, int defaultMask, Func<string, string> formatSelectedValueCallback = null, Func<string, string> formatListItemCallback = null);
    public MaskField(string label, List<string> choices, int defaultMask, Func<string, string> formatSelectedValueCallback = null, Func<string, string> formatListItemCallback = null);

    public void SetValueWithoutNotify(int newValue);

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.MaskField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<int>
    {
        public UxmlTraits();

        public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

    }

}

}
