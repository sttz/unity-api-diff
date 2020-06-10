using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public interface IEdgeConnectorListener
{
    public void OnDrop(UnityEditor.Experimental.GraphView.GraphView graphView, UnityEditor.Experimental.GraphView.Edge edge);
    public void OnDropOutsidePort(UnityEditor.Experimental.GraphView.Edge edge, Vector2 position);

}

}
