using System;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class ToolbarToggle : UIElements.Toggle
{
    static public string ussClassName;

    public ToolbarToggle();

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.ToolbarToggle, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public UxmlTraits();

    }

}

}
