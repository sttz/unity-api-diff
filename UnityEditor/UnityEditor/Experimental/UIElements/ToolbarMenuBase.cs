using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public abstract class ToolbarMenuBase : Experimental.UIElements.TextElement, UnityEditor.Experimental.UIElements.IToolbarMenuElement
{
    public Experimental.UIElements.DropdownMenu menu { get; }

    protected ToolbarMenuBase(string classList);

}

}
