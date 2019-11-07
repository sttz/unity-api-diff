using System;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class ToolbarSpacer : UIElements.VisualElement
{
    static public string fixedSpacerVariantUssClassName;
    static public string flexibleSpacerVariantUssClassName;
    static public string ussClassName;

    public bool flex { get; set; }

    public ToolbarSpacer();

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.ToolbarSpacer>
    {
        public UxmlFactory();

    }

}

}
