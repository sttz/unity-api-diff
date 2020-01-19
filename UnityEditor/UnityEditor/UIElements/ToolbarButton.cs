using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class ToolbarButton : UIElements.Button
{
    static public string ussClassName;

    public ToolbarButton();
    public ToolbarButton(Action clickEvent);

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
