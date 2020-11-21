using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public interface ISelection
{
    public List<UnityEditor.Experimental.GraphView.ISelectable> selection { get; }

    public void AddToSelection(UnityEditor.Experimental.GraphView.ISelectable selectable);
    public void ClearSelection();
    public void RemoveFromSelection(UnityEditor.Experimental.GraphView.ISelectable selectable);

}

}
