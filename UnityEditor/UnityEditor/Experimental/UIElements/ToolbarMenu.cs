using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public class ToolbarMenu : UnityEditor.Experimental.UIElements.ToolbarMenuBase
{
    public ToolbarMenu();

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<UnityEditor.Experimental.UIElements.ToolbarMenu, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public UxmlTraits();

    }

}

}
