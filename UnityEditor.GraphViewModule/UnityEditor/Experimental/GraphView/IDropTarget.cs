using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public interface IDropTarget
{
    public bool CanAcceptDrop(List<UnityEditor.Experimental.GraphView.ISelectable> selection);
    public bool DragEnter(UIElements.DragEnterEvent evt, IEnumerable<UnityEditor.Experimental.GraphView.ISelectable> selection, UnityEditor.Experimental.GraphView.IDropTarget enteredTarget, UnityEditor.Experimental.GraphView.ISelection dragSource);
    public bool DragExited();
    public bool DragLeave(UIElements.DragLeaveEvent evt, IEnumerable<UnityEditor.Experimental.GraphView.ISelectable> selection, UnityEditor.Experimental.GraphView.IDropTarget leftTarget, UnityEditor.Experimental.GraphView.ISelection dragSource);
    public bool DragPerform(UIElements.DragPerformEvent evt, IEnumerable<UnityEditor.Experimental.GraphView.ISelectable> selection, UnityEditor.Experimental.GraphView.IDropTarget dropTarget, UnityEditor.Experimental.GraphView.ISelection dragSource);
    public bool DragUpdated(UIElements.DragUpdatedEvent evt, IEnumerable<UnityEditor.Experimental.GraphView.ISelectable> selection, UnityEditor.Experimental.GraphView.IDropTarget dropTarget, UnityEditor.Experimental.GraphView.ISelection dragSource);

}

}
