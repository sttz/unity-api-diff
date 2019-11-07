using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public interface ISelection
{
    public System.Collections.Generic.List<UnityEditor.Experimental.UIElements.GraphView.ISelectable> selection { get; }

    public void AddToSelection(UnityEditor.Experimental.UIElements.GraphView.ISelectable selectable);
    public void ClearSelection();
    public void RemoveFromSelection(UnityEditor.Experimental.UIElements.GraphView.ISelectable selectable);

}

}
