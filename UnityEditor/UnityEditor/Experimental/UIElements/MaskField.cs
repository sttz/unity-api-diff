using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public class MaskField : UnityEditor.Experimental.UIElements.BasePopupField<int, string>
{
    public Func<string, string> formatListItemCallback { get; set; }
    public Func<string, string> formatSelectedValueCallback { get; set; }

    public MaskField(System.Collections.Generic.List<string> choices, int defaultMask, Func<string, string> formatSelectedValueCallback = null, Func<string, string> formatListItemCallback = null);
    public MaskField();

    public void SetValueWithoutNotify(int newValue);

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<UnityEditor.Experimental.UIElements.MaskField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<int>
    {
        public UxmlTraits();

        public void Init(Experimental.UIElements.VisualElement ve, Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

    }

}

}
