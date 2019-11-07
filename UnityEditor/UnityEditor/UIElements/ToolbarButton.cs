using System;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class ToolbarButton : UIElements.Button
{
    static public string ussClassName;

    public ToolbarButton(Action clickEvent);
    public ToolbarButton();

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.ToolbarButton, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public UxmlTraits();

    }

}

}
