using System;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class PlacematContainer : Layer
{
    static public int PlacematsLayer { get; }

    public System.Collections.Generic.IEnumerable<UnityEditor.Experimental.GraphView.Placemat> Placemats { get; }

    public PlacematContainer(UnityEditor.Experimental.GraphView.GraphView graphView);

    public T CreatePlacemat(Rect placematPosition, string placematTitle);
    public T CreatePlacemat(Func<T> creator, Rect placematPosition, string placematTitle);
    public bool GetPortCenterOverride(UnityEditor.Experimental.GraphView.Port port, out Vector2 overriddenPosition);
    public void HideCollapsedEdges();
    public void RemoveAllPlacemats();
    protected void UpdateElementsOrder();

    public enum CycleDirection
    {
        Up = 0,
        Down = 1,
    }

}

}
