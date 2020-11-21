using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class PlacematContainer : Layer
{
    static public int PlacematsLayer { get; }

    public IEnumerable<UnityEditor.Experimental.GraphView.Placemat> Placemats { get; }

    public PlacematContainer(UnityEditor.Experimental.GraphView.GraphView graphView);

    public T CreatePlacemat<T>(Rect placematPosition, int zOrder, string placematTitle);
    public T CreatePlacemat<T>(Func<T> creator, Rect placematPosition, int zOrder, string placematTitle);
    public bool GetPortCenterOverride(UnityEditor.Experimental.GraphView.Port port, out Vector2 overriddenPosition);
    public int GetTopZOrder();
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
