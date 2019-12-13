using System;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class Group : UnityEditor.Experimental.GraphView.Scope, UnityEditor.Experimental.GraphView.ICollectibleElement
{
    public string title { get; set; }

    public Group();

    public bool AcceptsElement(UnityEditor.Experimental.GraphView.GraphElement element, string reasonWhyNotAccepted);
    public void CollectElements(System.Collections.Generic.HashSet<UnityEditor.Experimental.GraphView.GraphElement> collectedElementSet, Func<UnityEditor.Experimental.GraphView.GraphElement, bool> conditionFunc);
    public void FocusTitleTextField();
    protected void OnElementsAdded(System.Collections.Generic.IEnumerable<UnityEditor.Experimental.GraphView.GraphElement> elements);
    protected void OnElementsRemoved(System.Collections.Generic.IEnumerable<UnityEditor.Experimental.GraphView.GraphElement> elements);
    protected void OnGroupRenamed(string oldName, string newName);

}

}
