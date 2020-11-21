using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class HelpBox : UIElements.VisualElement
{
    static public string iconErrorUssClassName;
    static public string iconInfoUssClassName;
    static public string iconUssClassName;
    static public string iconwarningUssClassName;
    static public string labelUssClassName;
    static public string ussClassName;

    public UIElements.HelpBoxMessageType messageType { get; set; }
    public string text { get; set; }

    public HelpBox();
    public HelpBox(string text, UIElements.HelpBoxMessageType messageType);

    public class UxmlFactory : UIElements.UxmlFactory<UIElements.HelpBox, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public UxmlTraits();

        public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

    }

}

}
