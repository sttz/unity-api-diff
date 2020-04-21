using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public interface ISelectable
{
    public bool HitTest(Vector2 localPoint);
    public bool IsSelectable();
    public bool IsSelected(UIElements.VisualElement selectionContainer);
    public bool Overlaps(Rect rectangle);
    public void Select(UIElements.VisualElement selectionContainer, bool additive);
    public void Unselect(UIElements.VisualElement selectionContainer);

}

}
