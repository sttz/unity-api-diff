using System;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public interface IDropTarget
{
    public bool CanAcceptDrop(System.Collections.Generic.List<UnityEditor.Experimental.GraphView.ISelectable> selection);
    public bool DragEnter(UIElements.DragEnterEvent evt, System.Collections.Generic.IEnumerable<UnityEditor.Experimental.GraphView.ISelectable> selection, UnityEditor.Experimental.GraphView.IDropTarget enteredTarget, UnityEditor.Experimental.GraphView.ISelection dragSource);
    public bool DragExited();
    public bool DragLeave(UIElements.DragLeaveEvent evt, System.Collections.Generic.IEnumerable<UnityEditor.Experimental.GraphView.ISelectable> selection, UnityEditor.Experimental.GraphView.IDropTarget leftTarget, UnityEditor.Experimental.GraphView.ISelection dragSource);
    public bool DragPerform(UIElements.DragPerformEvent evt, System.Collections.Generic.IEnumerable<UnityEditor.Experimental.GraphView.ISelectable> selection, UnityEditor.Experimental.GraphView.IDropTarget dropTarget, UnityEditor.Experimental.GraphView.ISelection dragSource);
    public bool DragUpdated(UIElements.DragUpdatedEvent evt, System.Collections.Generic.IEnumerable<UnityEditor.Experimental.GraphView.ISelectable> selection, UnityEditor.Experimental.GraphView.IDropTarget dropTarget, UnityEditor.Experimental.GraphView.ISelection dragSource);

}

}
