using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public struct GraphViewChange
{
    public List<UnityEditor.Experimental.UIElements.GraphView.Edge> edgesToCreate;
    public List<UnityEditor.Experimental.UIElements.GraphView.GraphElement> elementsToRemove;
    public List<UnityEditor.Experimental.UIElements.GraphView.GraphElement> movedElements;
    public Vector2 moveDelta;

}

}
