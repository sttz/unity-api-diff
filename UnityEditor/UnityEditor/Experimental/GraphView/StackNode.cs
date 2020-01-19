using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class StackNode : UnityEditor.Experimental.GraphView.Node, UnityEditor.Experimental.GraphView.IDropTarget
{
    public UIElements.VisualElement contentContainer { get; }
    protected bool dragEntered { get; private set; }
    public Func<UnityEditor.Experimental.GraphView.GraphElement, UIElements.VisualElement> dropPreviewTemplate { get; set; }
    protected bool hasMultipleSelectionSupport { get; }
    public UIElements.VisualElement headerContainer { get; private set; }

    public StackNode();

    protected bool AcceptsElement(UnityEditor.Experimental.GraphView.GraphElement element, int proposedIndex, int maxIndex);
    public void AddElement(UnityEditor.Experimental.GraphView.GraphElement element);
    public bool CanAcceptDrop(List<UnityEditor.Experimental.GraphView.ISelectable> selection);
    public bool DragEnter(UIElements.DragEnterEvent evt, IEnumerable<UnityEditor.Experimental.GraphView.ISelectable> selection, UnityEditor.Experimental.GraphView.IDropTarget enteredTarget, UnityEditor.Experimental.GraphView.ISelection dragSource);
    public bool DragExited();
    public bool DragLeave(UIElements.DragLeaveEvent evt, IEnumerable<UnityEditor.Experimental.GraphView.ISelectable> selection, UnityEditor.Experimental.GraphView.IDropTarget leftTarget, UnityEditor.Experimental.GraphView.ISelection dragSource);
    public bool DragPerform(UIElements.DragPerformEvent evt, IEnumerable<UnityEditor.Experimental.GraphView.ISelectable> selection, UnityEditor.Experimental.GraphView.IDropTarget dropTarget, UnityEditor.Experimental.GraphView.ISelection dragSource);
    public bool DragUpdated(UIElements.DragUpdatedEvent evt, IEnumerable<UnityEditor.Experimental.GraphView.ISelectable> selection, UnityEditor.Experimental.GraphView.IDropTarget dropTarget, UnityEditor.Experimental.GraphView.ISelection dragSource);
    public int GetInsertionIndex(Vector2 worldPosition);
    public void InsertElement(int index, UnityEditor.Experimental.GraphView.GraphElement element);
    protected void OnCustomStyleResolved(UIElements.ICustomStyle styles);
    protected void OnSeparatorContextualMenuEvent(UIElements.ContextualMenuPopulateEvent evt, int separatorIndex);
    public void OnStartDragging(UnityEditor.Experimental.GraphView.GraphElement ge);
    public void RemoveElement(UnityEditor.Experimental.GraphView.GraphElement element);

}

}
