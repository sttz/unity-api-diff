using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class RepeatButton : Experimental.UIElements.TextElement
{
    public RepeatButton();
    public RepeatButton(Action clickEvent, long delay, long interval);

    public void SetAction(Action clickEvent, long delay, long interval);

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<Experimental.UIElements.RepeatButton, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public UxmlTraits();

        public void Init(Experimental.UIElements.VisualElement ve, Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

    }

}

}
