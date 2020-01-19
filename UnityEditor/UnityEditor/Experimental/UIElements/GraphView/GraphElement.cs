using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public abstract class GraphElement : Experimental.UIElements.VisualElement, UnityEditor.Experimental.UIElements.GraphView.ISelectable
{
    public UnityEditor.Experimental.UIElements.GraphView.Capabilities capabilities { get; set; }
    public Color elementTypeColor { get; set; }
    public int layer { get; set; }
    public bool selected { get; set; }
    public string title { get; set; }

    protected GraphElement();

    public Vector3 GetGlobalCenter();
    public Rect GetPosition();
    public bool HitTest(Vector2 localPoint);
    public bool IsAscendable();
    public bool IsDroppable();
    public bool IsMovable();
    public bool IsResizable();
    public bool IsSelectable();
    public bool IsSelected(Experimental.UIElements.VisualElement selectionContainer);
    public void OnSelected();
    protected void OnStyleResolved(Experimental.UIElements.StyleSheets.ICustomStyle style);
    public void OnUnselected();
    public void ResetLayer();
    public void Select(Experimental.UIElements.VisualElement selectionContainer, bool additive);
    public void SetPosition(Rect newPos);
    public void Unselect(Experimental.UIElements.VisualElement selectionContainer);
    public void UpdatePresenterPosition();

}

}
