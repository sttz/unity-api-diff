using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public struct SearchWindowContext
{
    public float requestedHeight { get; private set; }
    public float requestedWidth { get; private set; }
    public Vector2 screenMousePosition { get; private set; }

    public SearchWindowContext(Vector2 screenMousePosition, float requestedWidth = 0, float requestedHeight = 0);

}

}
