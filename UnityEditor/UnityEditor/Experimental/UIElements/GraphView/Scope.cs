using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public class Scope : UnityEditor.Experimental.UIElements.GraphView.GraphElement
{
    public bool autoUpdateGeometry { get; set; }
    public IEnumerable<UnityEditor.Experimental.UIElements.GraphView.GraphElement> containedElements { get; }
    public Rect containedElementsRect { get; }
    public Experimental.UIElements.VisualElement headerContainer { get; }

    public Scope();

    public bool AcceptsElement(UnityEditor.Experimental.UIElements.GraphView.GraphElement element, string reasonWhyNotAccepted);
    public void AddElement(UnityEditor.Experimental.UIElements.GraphView.GraphElement element);
    public void AddElements(IEnumerable<UnityEditor.Experimental.UIElements.GraphView.GraphElement> elements);
    public bool ContainsElement(UnityEditor.Experimental.UIElements.GraphView.GraphElement element);
    public Rect GetPosition();
    public bool HitTest(Vector2 localPoint);
    protected void OnElementsAdded(IEnumerable<UnityEditor.Experimental.UIElements.GraphView.GraphElement> elements);
    protected void OnElementsRemoved(IEnumerable<UnityEditor.Experimental.UIElements.GraphView.GraphElement> elements);
    public bool Overlaps(Rect rectangle);
    public void RemoveElement(UnityEditor.Experimental.UIElements.GraphView.GraphElement element);
    public void RemoveElements(IEnumerable<UnityEditor.Experimental.UIElements.GraphView.GraphElement> elements);
    public void RemoveElementsWithoutNotification(IEnumerable<UnityEditor.Experimental.UIElements.GraphView.GraphElement> elements);
    protected void ScheduleUpdateGeometryFromContent();
    public void SetPosition(Rect newPos);
    protected void SetScopePositionOnly(Rect newPos);
    public void UpdateGeometryFromContent();
    public void UpdatePresenterPosition();

}

}
