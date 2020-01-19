using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public class MiniMap : UnityEditor.Experimental.UIElements.GraphView.GraphElement
{
    public bool anchored { get; set; }
    public float maxHeight { get; set; }
    public float maxWidth { get; set; }

    public MiniMap();

    public void BuildContextualMenu(Experimental.UIElements.ContextualMenuPopulateEvent evt);
    protected void DoRepaint(Experimental.UIElements.IStylePainter painter);

}

}
