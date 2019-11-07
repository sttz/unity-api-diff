using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public class ToolbarPopupSearchField : UnityEditor.Experimental.UIElements.ToolbarSearchField, UnityEditor.Experimental.UIElements.IToolbarMenuElement
{
    public Experimental.UIElements.DropdownMenu menu { get; }

    public ToolbarPopupSearchField();

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<UnityEditor.Experimental.UIElements.ToolbarPopupSearchField>
    {
        public UxmlFactory();

    }

}

}
