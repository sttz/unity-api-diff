using System;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class ToolbarBreadcrumbs : UIElements.VisualElement
{
    static public string firstItemClassName;
    static public string itemClassName;
    static public string ussClassName;

    public ToolbarBreadcrumbs();

    public void PopItem();
    public void PushItem(string label, Action clickedEvent = null);

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.ToolbarBreadcrumbs>
    {
        public UxmlFactory();

    }

}

}
