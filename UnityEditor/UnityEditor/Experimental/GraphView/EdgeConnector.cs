using System;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public abstract class EdgeConnector : UIElements.MouseManipulator
{
    public UnityEditor.Experimental.GraphView.EdgeDragHelper edgeDragHelper { get; }

    protected EdgeConnector();

}

}
