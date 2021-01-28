using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class GroupBox : UIElements.BindableElement, UIElements.IGroupBox
{
    static public string labelUssClassName;
    static public string ussClassName;

    public string text { get; set; }

    public GroupBox();
    public GroupBox(string text);

    public class UxmlFactory : UIElements.UxmlFactory<UIElements.GroupBox, UxmlTraits>
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
