using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public class Group : UnityEditor.Experimental.UIElements.GraphView.Scope
{
    public string title { get; set; }

    public Group();

    public bool AcceptsElement(UnityEditor.Experimental.UIElements.GraphView.GraphElement element, string reasonWhyNotAccepted);
    protected void OnElementsAdded(IEnumerable<UnityEditor.Experimental.UIElements.GraphView.GraphElement> elements);
    protected void OnElementsRemoved(IEnumerable<UnityEditor.Experimental.UIElements.GraphView.GraphElement> elements);
    protected void OnGroupRenamed(string oldName, string newName);

}

}
