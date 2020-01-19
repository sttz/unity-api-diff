using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class ToolbarMenu : UIElements.TextElement, UnityEditor.UIElements.IToolbarMenuElement
{
    static public string popupVariantUssClassName;
    static public string ussClassName;

    public UIElements.DropdownMenu menu { get; }
    public Variant variant { get; set; }

    public ToolbarMenu();

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.ToolbarMenu, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public UxmlTraits();

    }

    public enum Variant
    {
        Default = 0,
        Popup = 1,
    }

}

}
