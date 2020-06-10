using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public abstract class EdgeConnector : UIElements.MouseManipulator
{
    public UnityEditor.Experimental.GraphView.EdgeDragHelper edgeDragHelper { get; }

    protected EdgeConnector();

}

}
