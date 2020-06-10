using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class RectUtils
{
    static public Rect Encompass(Rect a, Rect b);
    static public Rect Inflate(Rect a, float left, float top, float right, float bottom);
    static public bool IntersectsSegment(Rect rect, Vector2 p1, Vector2 p2);

    public RectUtils();

}

}
