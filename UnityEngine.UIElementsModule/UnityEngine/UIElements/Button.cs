using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class Button : UIElements.TextElement
{
    static public string ussClassName;

    public UIElements.Clickable clickable { get; set; }

    public Button();
    public Button(Action clickEvent);

    public class UxmlFactory : UIElements.UxmlFactory<UIElements.Button, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public UxmlTraits();

    }

}

}
