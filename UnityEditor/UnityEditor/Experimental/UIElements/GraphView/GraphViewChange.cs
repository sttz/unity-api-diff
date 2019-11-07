using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public struct GraphViewChange
{
    public System.Collections.Generic.List<UnityEditor.Experimental.UIElements.GraphView.Edge> edgesToCreate;
    public System.Collections.Generic.List<UnityEditor.Experimental.UIElements.GraphView.GraphElement> elementsToRemove;
    public System.Collections.Generic.List<UnityEditor.Experimental.UIElements.GraphView.GraphElement> movedElements;
    public Vector2 moveDelta;

}

}
