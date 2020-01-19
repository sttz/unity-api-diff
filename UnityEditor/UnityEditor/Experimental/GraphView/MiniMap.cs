using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class MiniMap : UnityEditor.Experimental.GraphView.GraphElement
{
    public bool anchored { get; set; }
    public float maxHeight { get; set; }
    public float maxWidth { get; set; }

    public MiniMap();

    public void BuildContextualMenu(UIElements.ContextualMenuPopulateEvent evt);
    public void OnResized();

}

}
