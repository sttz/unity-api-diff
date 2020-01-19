using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public struct GraphViewChange
{
    public List<UnityEditor.Experimental.GraphView.Edge> edgesToCreate;
    public List<UnityEditor.Experimental.GraphView.GraphElement> elementsToRemove;
    public List<UnityEditor.Experimental.GraphView.GraphElement> movedElements;
    public Vector2 moveDelta;

}

}
