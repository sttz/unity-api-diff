using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public interface IEdgeConnectorListener
{
    public void OnDrop(UnityEditor.Experimental.UIElements.GraphView.GraphView graphView, UnityEditor.Experimental.UIElements.GraphView.Edge edge);
    public void OnDropOutsidePort(UnityEditor.Experimental.UIElements.GraphView.Edge edge, Vector2 position);

}

}
