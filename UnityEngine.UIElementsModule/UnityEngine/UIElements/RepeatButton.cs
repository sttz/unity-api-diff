using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class RepeatButton : UIElements.TextElement
{
    static public string ussClassName;

    public RepeatButton();
    public RepeatButton(Action clickEvent, long delay, long interval);

    public void SetAction(Action clickEvent, long delay, long interval);

    public class UxmlFactory : UIElements.UxmlFactory<UIElements.RepeatButton, UxmlTraits>
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
