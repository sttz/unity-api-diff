using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public interface IDropTarget
{
    public bool CanAcceptDrop(System.Collections.Generic.List<UnityEditor.Experimental.UIElements.GraphView.ISelectable> selection);
    public bool DragEnter(Experimental.UIElements.DragEnterEvent evt, System.Collections.Generic.IEnumerable<UnityEditor.Experimental.UIElements.GraphView.ISelectable> selection, UnityEditor.Experimental.UIElements.GraphView.IDropTarget enteredTarget, UnityEditor.Experimental.UIElements.GraphView.ISelection dragSource);
    public bool DragExited();
    public bool DragLeave(Experimental.UIElements.DragLeaveEvent evt, System.Collections.Generic.IEnumerable<UnityEditor.Experimental.UIElements.GraphView.ISelectable> selection, UnityEditor.Experimental.UIElements.GraphView.IDropTarget leftTarget, UnityEditor.Experimental.UIElements.GraphView.ISelection dragSource);
    public bool DragPerform(Experimental.UIElements.DragPerformEvent evt, System.Collections.Generic.IEnumerable<UnityEditor.Experimental.UIElements.GraphView.ISelectable> selection, UnityEditor.Experimental.UIElements.GraphView.IDropTarget dropTarget, UnityEditor.Experimental.UIElements.GraphView.ISelection dragSource);
    public bool DragUpdated(Experimental.UIElements.DragUpdatedEvent evt, System.Collections.Generic.IEnumerable<UnityEditor.Experimental.UIElements.GraphView.ISelectable> selection, UnityEditor.Experimental.UIElements.GraphView.IDropTarget dropTarget, UnityEditor.Experimental.UIElements.GraphView.ISelection dragSource);

}

}
