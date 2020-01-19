using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class ScrollerButton : Experimental.UIElements.VisualElement
{
    public Experimental.UIElements.Clickable clickable;

    public ScrollerButton();
    public ScrollerButton(Action clickEvent, long delay, long interval);

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<Experimental.UIElements.ScrollerButton, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public IEnumerable<Experimental.UIElements.UxmlChildElementDescription> uxmlChildElementsDescription { get; }

        public UxmlTraits();

        public void Init(Experimental.UIElements.VisualElement ve, Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

    }

}

}
