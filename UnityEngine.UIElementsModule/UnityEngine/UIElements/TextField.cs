using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class TextField : UIElements.TextInputBaseField<string>
{
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string ussClassName;

    public bool multiline { get; set; }
    public string value { get; set; }

    public TextField();
    public TextField(string label);
    public TextField(int maxLength, bool multiline, bool isPasswordField, char maskChar);
    public TextField(string label, int maxLength, bool multiline, bool isPasswordField, char maskChar);

    public void SelectRange(int rangeCursorIndex, int selectionIndex);
    public void SetValueWithoutNotify(string newValue);
    protected string StringToValue(string str);
    protected string ValueToString(string value);

    public class UxmlFactory : UIElements.UxmlFactory<UIElements.TextField, UxmlTraits>
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
