using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public interface ISelection
{
    public List<UnityEditor.Experimental.UIElements.GraphView.ISelectable> selection { get; }

    public void AddToSelection(UnityEditor.Experimental.UIElements.GraphView.ISelectable selectable);
    public void ClearSelection();
    public void RemoveFromSelection(UnityEditor.Experimental.UIElements.GraphView.ISelectable selectable);

}

}
