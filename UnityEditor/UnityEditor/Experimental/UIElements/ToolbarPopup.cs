using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public class ToolbarPopup : UnityEditor.Experimental.UIElements.ToolbarMenuBase
{
    public ToolbarPopup();

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<UnityEditor.Experimental.UIElements.ToolbarPopup, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public UxmlTraits();

    }

}

}
