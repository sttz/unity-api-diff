using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public class Group : UnityEditor.Experimental.UIElements.GraphView.Scope
{
    public string title { get; set; }

    public Group();

    public bool AcceptsElement(UnityEditor.Experimental.UIElements.GraphView.GraphElement element, string reasonWhyNotAccepted);
    protected void OnElementsAdded(System.Collections.Generic.IEnumerable<UnityEditor.Experimental.UIElements.GraphView.GraphElement> elements);
    protected void OnElementsRemoved(System.Collections.Generic.IEnumerable<UnityEditor.Experimental.UIElements.GraphView.GraphElement> elements);
    protected void OnGroupRenamed(string oldName, string newName);

}

}
