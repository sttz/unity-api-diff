using System;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class MaskField : UnityEditor.UIElements.BaseMaskField<int>
{
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string ussClassName;

    public Func<string, string> formatListItemCallback { get; set; }
    public Func<string, string> formatSelectedValueCallback { get; set; }

    public MaskField(System.Collections.Generic.List<string> choices, int defaultMask, Func<string, string> formatSelectedValueCallback = null, Func<string, string> formatListItemCallback = null);
    public MaskField(string label, System.Collections.Generic.List<string> choices, int defaultMask, Func<string, string> formatSelectedValueCallback = null, Func<string, string> formatListItemCallback = null);
    public MaskField();
    public MaskField(string label);

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
