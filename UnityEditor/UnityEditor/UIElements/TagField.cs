using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class TagField : UnityEditor.UIElements.PopupField<string>
{
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string ussClassName;

    public Func<string, string> formatListItemCallback { get; set; }
    public Func<string, string> formatSelectedValueCallback { get; set; }
    public string value { get; set; }

    public TagField();
    public TagField(string label, string defaultValue = null);

    public void SetValueWithoutNotify(string newValue);

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.TagField, UxmlTraits>
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
