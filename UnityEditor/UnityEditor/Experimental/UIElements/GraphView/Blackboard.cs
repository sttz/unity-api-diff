using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public class Blackboard : UnityEditor.Experimental.UIElements.GraphView.GraphElement
{
    public Action<UnityEditor.Experimental.UIElements.GraphView.Blackboard> addItemRequested { get; set; }
    public Experimental.UIElements.VisualElement contentContainer { get; }
    public Action<UnityEditor.Experimental.UIElements.GraphView.Blackboard, Experimental.UIElements.VisualElement, string> editTextRequested { get; set; }
    public Action<UnityEditor.Experimental.UIElements.GraphView.Blackboard, int, Experimental.UIElements.VisualElement> moveItemRequested { get; set; }
    public bool scrollable { get; set; }
    public string subTitle { get; set; }
    public string title { get; set; }

    public Blackboard();

}

}
