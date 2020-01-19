using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class IMGUIContainer : Experimental.UIElements.VisualElement
{
    public bool canGrabFocus { get; }
    public Experimental.UIElements.ContextType contextType { get; set; }

    public IMGUIContainer();
    public IMGUIContainer(Action onGUIHandler);

    protected void DoRepaint(Experimental.UIElements.IStylePainter painter);
    public void HandleEvent(Experimental.UIElements.EventBase evt);
    public void MarkDirtyLayout();

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<Experimental.UIElements.IMGUIContainer, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public IEnumerable<Experimental.UIElements.UxmlChildElementDescription> uxmlChildElementsDescription { get; }

        public UxmlTraits();

    }

}

}
