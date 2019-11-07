using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public class RectangleSelector : Experimental.UIElements.MouseManipulator
{
    public RectangleSelector();

    public Rect ComputeAxisAlignedBound(Rect position, Matrix4x4 transform);
    protected void RegisterCallbacksOnTarget();
    protected void UnregisterCallbacksFromTarget();

}

}
