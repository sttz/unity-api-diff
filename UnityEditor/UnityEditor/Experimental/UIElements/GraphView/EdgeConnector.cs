using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public abstract class EdgeConnector : Experimental.UIElements.MouseManipulator
{
    public UnityEditor.Experimental.UIElements.GraphView.EdgeDragHelper edgeDragHelper { get; }

    protected EdgeConnector();

}

}
