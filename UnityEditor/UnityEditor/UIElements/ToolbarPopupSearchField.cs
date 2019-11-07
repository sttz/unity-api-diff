using System;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class ToolbarPopupSearchField : UnityEditor.UIElements.ToolbarSearchField, UnityEditor.UIElements.IToolbarMenuElement
{
    public UIElements.DropdownMenu menu { get; }

    public ToolbarPopupSearchField();

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.ToolbarPopupSearchField>
    {
        public UxmlFactory();

    }

}

}
