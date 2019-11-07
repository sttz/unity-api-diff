using System;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class Group : UnityEditor.Experimental.GraphView.Scope
{
    public string title { get; set; }

    public Group();

    public bool AcceptsElement(UnityEditor.Experimental.GraphView.GraphElement element, string reasonWhyNotAccepted);
    protected void OnElementsAdded(System.Collections.Generic.IEnumerable<UnityEditor.Experimental.GraphView.GraphElement> elements);
    protected void OnElementsRemoved(System.Collections.Generic.IEnumerable<UnityEditor.Experimental.GraphView.GraphElement> elements);
    protected void OnGroupRenamed(string oldName, string newName);

}

}
