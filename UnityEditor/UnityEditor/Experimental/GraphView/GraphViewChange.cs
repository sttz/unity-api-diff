using System;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public struct GraphViewChange
{
    public System.Collections.Generic.List<UnityEditor.Experimental.GraphView.Edge> edgesToCreate;
    public System.Collections.Generic.List<UnityEditor.Experimental.GraphView.GraphElement> elementsToRemove;
    public System.Collections.Generic.List<UnityEditor.Experimental.GraphView.GraphElement> movedElements;
    public Vector2 moveDelta;

}

}
