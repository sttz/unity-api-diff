using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class Blackboard : UnityEditor.Experimental.GraphView.GraphElement, UnityEditor.Experimental.GraphView.ISelection
{
    public Action<UnityEditor.Experimental.GraphView.Blackboard> addItemRequested { get; set; }
    public UIElements.VisualElement contentContainer { get; }
    public Action<UnityEditor.Experimental.GraphView.Blackboard, UIElements.VisualElement, string> editTextRequested { get; set; }
    public UnityEditor.Experimental.GraphView.GraphView graphView { get; set; }
    public Action<UnityEditor.Experimental.GraphView.Blackboard, int, UIElements.VisualElement> moveItemRequested { get; set; }
    public bool scrollable { get; set; }
    public List<UnityEditor.Experimental.GraphView.ISelectable> selection { get; }
    public string subTitle { get; set; }
    public string title { get; set; }
    public bool windowed { get; set; }

    public Blackboard(UnityEditor.Experimental.GraphView.GraphView associatedGraphView = null);

    public void AddToSelection(UnityEditor.Experimental.GraphView.ISelectable selectable);
    public void ClearSelection();
    public void RemoveFromSelection(UnityEditor.Experimental.GraphView.ISelectable selectable);

}

}
