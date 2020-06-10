using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class BlackboardSection : UnityEditor.Experimental.GraphView.GraphElement
{
    public CanAcceptDropDelegate canAcceptDrop { get; set; }
    public UIElements.VisualElement contentContainer { get; }
    public bool headerVisible { get; set; }
    public string title { get; set; }

    public BlackboardSection();

    public bool CanAcceptDrop(List<UnityEditor.Experimental.GraphView.ISelectable> selection);

    public delegate bool CanAcceptDropDelegate(UnityEditor.Experimental.GraphView.ISelectable selected);

}

}
