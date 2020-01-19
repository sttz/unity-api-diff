using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class MiniMap : UnityEditor.Experimental.GraphView.GraphElement
{
    public Action<string> zoomFactorTextChanged;

    public bool anchored { get; set; }
    public UnityEditor.Experimental.GraphView.GraphView graphView { get; set; }
    public float maxHeight { get; set; }
    public float maxWidth { get; set; }
    public bool windowed { get; set; }

    public MiniMap();

    public void BuildContextualMenu(UIElements.ContextualMenuPopulateEvent evt);
    public void OnResized();

}

}
