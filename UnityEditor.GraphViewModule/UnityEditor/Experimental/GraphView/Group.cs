using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class Group : UnityEditor.Experimental.GraphView.Scope, UnityEditor.Experimental.GraphView.ICollectibleElement
{
    public string title { get; set; }

    public Group();

    public bool AcceptsElement(UnityEditor.Experimental.GraphView.GraphElement element, string reasonWhyNotAccepted);
    public void CollectElements(HashSet<UnityEditor.Experimental.GraphView.GraphElement> collectedElementSet, Func<UnityEditor.Experimental.GraphView.GraphElement, bool> conditionFunc);
    public void FocusTitleTextField();
    protected void OnElementsAdded(IEnumerable<UnityEditor.Experimental.GraphView.GraphElement> elements);
    protected void OnElementsRemoved(IEnumerable<UnityEditor.Experimental.GraphView.GraphElement> elements);
    protected void OnGroupRenamed(string oldName, string newName);

}

}
