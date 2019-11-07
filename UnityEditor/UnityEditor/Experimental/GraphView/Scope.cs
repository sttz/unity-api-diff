using System;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class Scope : UnityEditor.Experimental.GraphView.GraphElement
{
    public bool autoUpdateGeometry { get; set; }
    public System.Collections.Generic.IEnumerable<UnityEditor.Experimental.GraphView.GraphElement> containedElements { get; }
    public Rect containedElementsRect { get; }
    public UIElements.VisualElement headerContainer { get; }

    public Scope();

    public bool AcceptsElement(UnityEditor.Experimental.GraphView.GraphElement element, string reasonWhyNotAccepted);
    public void AddElement(UnityEditor.Experimental.GraphView.GraphElement element);
    public void AddElements(System.Collections.Generic.IEnumerable<UnityEditor.Experimental.GraphView.GraphElement> elements);
    public bool ContainsElement(UnityEditor.Experimental.GraphView.GraphElement element);
    public Rect GetPosition();
    public bool HitTest(Vector2 localPoint);
    protected void OnElementsAdded(System.Collections.Generic.IEnumerable<UnityEditor.Experimental.GraphView.GraphElement> elements);
    protected void OnElementsRemoved(System.Collections.Generic.IEnumerable<UnityEditor.Experimental.GraphView.GraphElement> elements);
    public bool Overlaps(Rect rectangle);
    public void RemoveElement(UnityEditor.Experimental.GraphView.GraphElement element);
    public void RemoveElements(System.Collections.Generic.IEnumerable<UnityEditor.Experimental.GraphView.GraphElement> elements);
    public void RemoveElementsWithoutNotification(System.Collections.Generic.IEnumerable<UnityEditor.Experimental.GraphView.GraphElement> elements);
    protected void ScheduleUpdateGeometryFromContent();
    public void SetPosition(Rect newPos);
    protected void SetScopePositionOnly(Rect newPos);
    public void UpdateGeometryFromContent();
    public void UpdatePresenterPosition();

}

}
