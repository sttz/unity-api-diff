using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class PopupWindow : UIElements.TextElement
{
    static public string contentUssClassName;
    static public string ussClassName;

    public UIElements.VisualElement contentContainer { get; }

    public PopupWindow();

    public class UxmlFactory : UIElements.UxmlFactory<UIElements.PopupWindow, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public System.Collections.Generic.IEnumerable<UIElements.UxmlChildElementDescription> uxmlChildElementsDescription { get; }

        public UxmlTraits();

    }

}

}
