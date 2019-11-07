using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public class GridBackground : Experimental.UIElements.VisualElement
{
    public GridBackground();

    protected void DoRepaint(Experimental.UIElements.IStylePainter painter);
    protected void OnStyleResolved(Experimental.UIElements.StyleSheets.ICustomStyle elementStyle);

}

}
