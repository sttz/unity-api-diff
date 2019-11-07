using System;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class Blackboard : UnityEditor.Experimental.GraphView.GraphElement
{
    public Action<UnityEditor.Experimental.GraphView.Blackboard> addItemRequested { get; set; }
    public UIElements.VisualElement contentContainer { get; }
    public Action<UnityEditor.Experimental.GraphView.Blackboard, UIElements.VisualElement, string> editTextRequested { get; set; }
    public Action<UnityEditor.Experimental.GraphView.Blackboard, int, UIElements.VisualElement> moveItemRequested { get; set; }
    public bool scrollable { get; set; }
    public string subTitle { get; set; }
    public string title { get; set; }

    public Blackboard();

}

}
