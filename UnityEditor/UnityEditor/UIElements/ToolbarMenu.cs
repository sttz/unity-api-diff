using System;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class ToolbarMenu : UIElements.TextElement, UnityEditor.UIElements.IToolbarMenuElement
{
    static public string arrowUssClassName;
    static public string popupVariantUssClassName;
    static public string textUssClassName;
    static public string ussClassName;

    public UIElements.DropdownMenu menu { get; }
    public string text { get; set; }
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
