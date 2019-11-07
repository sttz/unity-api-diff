using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public class BlackboardSection : UnityEditor.Experimental.UIElements.GraphView.GraphElement
{
    public Experimental.UIElements.VisualElement contentContainer { get; }
    public bool headerVisible { get; set; }
    public string title { get; set; }

    public BlackboardSection();

    public bool CanAcceptDrop(System.Collections.Generic.List<UnityEditor.Experimental.UIElements.GraphView.ISelectable> selection);

}

}
