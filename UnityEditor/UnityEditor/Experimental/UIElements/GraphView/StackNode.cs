using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public class StackNode : UnityEditor.Experimental.UIElements.GraphView.Node, UnityEditor.Experimental.UIElements.GraphView.IDropTarget
{
    public Experimental.UIElements.VisualElement contentContainer { get; }
    protected bool dragEntered { get; private set; }
    public Func<UnityEditor.Experimental.UIElements.GraphView.GraphElement, Experimental.UIElements.VisualElement> dropPreviewTemplate { get; set; }
    protected bool hasMultipleSelectionSupport { get; }
    public Experimental.UIElements.VisualElement headerContainer { get; private set; }

    public StackNode();

    protected bool AcceptsElement(UnityEditor.Experimental.UIElements.GraphView.GraphElement element, int proposedIndex, int maxIndex);
    public void AddElement(UnityEditor.Experimental.UIElements.GraphView.GraphElement element);
    public bool CanAcceptDrop(List<UnityEditor.Experimental.UIElements.GraphView.ISelectable> selection);
    public bool DragEnter(Experimental.UIElements.DragEnterEvent evt, IEnumerable<UnityEditor.Experimental.UIElements.GraphView.ISelectable> selection, UnityEditor.Experimental.UIElements.GraphView.IDropTarget enteredTarget, UnityEditor.Experimental.UIElements.GraphView.ISelection dragSource);
    public bool DragExited();
    public bool DragLeave(Experimental.UIElements.DragLeaveEvent evt, IEnumerable<UnityEditor.Experimental.UIElements.GraphView.ISelectable> selection, UnityEditor.Experimental.UIElements.GraphView.IDropTarget leftTarget, UnityEditor.Experimental.UIElements.GraphView.ISelection dragSource);
    public bool DragPerform(Experimental.UIElements.DragPerformEvent evt, IEnumerable<UnityEditor.Experimental.UIElements.GraphView.ISelectable> selection, UnityEditor.Experimental.UIElements.GraphView.IDropTarget dropTarget, UnityEditor.Experimental.UIElements.GraphView.ISelection dragSource);
    public bool DragUpdated(Experimental.UIElements.DragUpdatedEvent evt, IEnumerable<UnityEditor.Experimental.UIElements.GraphView.ISelectable> selection, UnityEditor.Experimental.UIElements.GraphView.IDropTarget dropTarget, UnityEditor.Experimental.UIElements.GraphView.ISelection dragSource);
    public int GetInsertionIndex(Vector2 worldPosition);
    public void InsertElement(int index, UnityEditor.Experimental.UIElements.GraphView.GraphElement element);
    protected void OnSeparatorContextualMenuEvent(Experimental.UIElements.ContextualMenuPopulateEvent evt, int separatorIndex);
    public void OnStartDragging(UnityEditor.Experimental.UIElements.GraphView.GraphElement ge);
    protected void OnStyleResolved(Experimental.UIElements.StyleSheets.ICustomStyle styles);
    public void RemoveElement(UnityEditor.Experimental.UIElements.GraphView.GraphElement element);

}

}
