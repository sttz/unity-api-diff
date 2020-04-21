using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.IMGUI.Controls
{

public abstract class PrimitiveBoundsHandle
{
    static public float DefaultMidpointHandleSizeFunction(Vector3 position);

    public Axes axes { get; set; }
    public Vector3 center { get; set; }
    public Color handleColor { get; set; }
    public CapFunction midpointHandleDrawFunction { get; set; }
    public SizeFunction midpointHandleSizeFunction { get; set; }
    public Color wireframeColor { get; set; }

    public PrimitiveBoundsHandle();
    public PrimitiveBoundsHandle(int controlIDHint);

    public void DrawHandle();
    protected void DrawWireframe();
    protected Vector3 GetSize();
    protected bool IsAxisEnabled(Axes axis);
    protected bool IsAxisEnabled(int vector3Axis);
    protected Bounds OnHandleChanged(HandleDirection handle, Bounds boundsOnClick, Bounds newBounds);
    public void SetColor(Color color);
    protected void SetSize(Vector3 size);

    public enum Axes
    {
        None = 0,
        X = 1,
        Y = 2,
        Z = 4,
        All = 7,
    }

    protected enum HandleDirection
    {
        PositiveX = 0,
        NegativeX = 1,
        PositiveY = 2,
        NegativeY = 3,
        PositiveZ = 4,
        NegativeZ = 5,
    }

}

}
