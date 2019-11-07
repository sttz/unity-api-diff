using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public interface ISelectable
{
    public bool HitTest(Vector2 localPoint);
    public bool IsSelectable();
    public bool IsSelected(Experimental.UIElements.VisualElement selectionContainer);
    public bool Overlaps(Rect rectangle);
    public void Select(Experimental.UIElements.VisualElement selectionContainer, bool additive);
    public void Unselect(Experimental.UIElements.VisualElement selectionContainer);

}

}
