using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public abstract class GraphElement : UIElements.VisualElement, UnityEditor.Experimental.GraphView.ISelectable
{
    public UnityEditor.Experimental.GraphView.Capabilities capabilities { get; set; }
    public Color elementTypeColor { get; set; }
    public int layer { get; set; }
    public bool selected { get; set; }
    public bool showInMiniMap { get; set; }
    public string title { get; set; }

    protected GraphElement();

    public Vector3 GetGlobalCenter();
    public Rect GetPosition();
    public bool HitTest(Vector2 localPoint);
    public bool IsAscendable();
    public bool IsCopiable();
    public bool IsDroppable();
    public bool IsGroupable();
    public bool IsMovable();
    public bool IsRenamable();
    public bool IsResizable();
    public bool IsSelectable();
    public bool IsSelected(UIElements.VisualElement selectionContainer);
    public bool IsSnappable();
    public bool IsStackable();
    protected void OnCustomStyleResolved(UIElements.ICustomStyle style);
    public void OnSelected();
    public void OnUnselected();
    public void ResetLayer();
    public void Select(UIElements.VisualElement selectionContainer, bool additive);
    public void SetPosition(Rect newPos);
    public void Unselect(UIElements.VisualElement selectionContainer);
    public void UpdatePresenterPosition();

}

}
