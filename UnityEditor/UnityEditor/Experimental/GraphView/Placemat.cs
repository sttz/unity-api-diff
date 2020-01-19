using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class Placemat : UnityEditor.Experimental.GraphView.GraphElement
{
    static public bool ComputeElementBounds(Rect pos, List<UnityEditor.Experimental.GraphView.GraphElement> elements, MinSizePolicy ensureMinSize = 0);

    protected UnityEditor.Experimental.GraphView.GraphView m_GraphView;

    public bool Collapsed { get; set; }
    public IEnumerable<UnityEditor.Experimental.GraphView.GraphElement> CollapsedElements { get; }
    public Vector2 CollapsedSize { get; }
    public Color Color { get; set; }
    public Rect ExpandedPosition { get; }
    public string title { get; set; }
    public Vector2 UncollapsedSize { get; private set; }
    public int ZOrder { get; set; }

    public Placemat();

    protected void BuildContextualMenu(UIElements.ContextualMenuPopulateEvent evt);
    protected void ExecuteDefaultActionAtTarget(UIElements.EventBase evt);
    public void SetPosition(Rect newPos);
    public void StartEditTitle();

    public enum MinSizePolicy
    {
        EnsureMinSize = 0,
        DoNotEnsureMinSize = 1,
    }

}

}
