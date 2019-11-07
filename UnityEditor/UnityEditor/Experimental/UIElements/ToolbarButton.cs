using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public class ToolbarButton : Experimental.UIElements.Button
{
    public ToolbarButton(Action clickEvent);
    public ToolbarButton();

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<UnityEditor.Experimental.UIElements.ToolbarButton, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public UxmlTraits();

    }

}

}
