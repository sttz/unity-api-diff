using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class TextField : Experimental.UIElements.TextInputFieldBase<string>
{
    public bool isPasswordField { set; }
    public bool multiline { get; set; }
    public string value { get; set; }

    public TextField();
    public TextField(int maxLength, bool multiline, bool isPasswordField, char maskChar);

    protected void DoRepaint(Experimental.UIElements.IStylePainter painter);
    public void OnPersistentDataReady();
    public void SelectRange(int cursorIndex, int selectionIndex);
    public void SetValueWithoutNotify(string newValue);

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<Experimental.UIElements.TextField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<string>
    {
        public UxmlTraits();

        public void Init(Experimental.UIElements.VisualElement ve, Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

    }

}

}
