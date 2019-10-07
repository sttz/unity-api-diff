using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class PopupWindow : Experimental.UIElements.TextElement
{
    public Experimental.UIElements.VisualElement contentContainer { get; }

    public PopupWindow();

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<Experimental.UIElements.PopupWindow, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public System.Collections.Generic.IEnumerable<Experimental.UIElements.UxmlChildElementDescription> uxmlChildElementsDescription { get; }

        public UxmlTraits();

    }

}

}
