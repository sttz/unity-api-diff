using System;
using System.Collections;
using System.Collections.Generic;
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
        public IEnumerable<UIElements.UxmlChildElementDescription> uxmlChildElementsDescription { get; }

        public UxmlTraits();

    }

}

}
