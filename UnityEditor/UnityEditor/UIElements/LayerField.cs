using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class LayerField : UnityEditor.UIElements.PopupField<int>
{
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string ussClassName;

    public Func<int, string> formatListItemCallback { get; set; }
    public Func<int, string> formatSelectedValueCallback { get; set; }
    public int value { get; set; }

    public LayerField();
    public LayerField(int defaultValue);
    public LayerField(string label);
    public LayerField(string label, int defaultValue);

    public void SetValueWithoutNotify(int newValue);

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.LayerField, UxmlTraits>
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
