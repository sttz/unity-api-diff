using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.IMGUI.Controls
{

public class CapsuleBoundsHandle : UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle
{
    public float height { get; set; }
    public HeightAxis heightAxis { get; set; }
    public float radius { get; set; }

    public CapsuleBoundsHandle();
    public CapsuleBoundsHandle(int controlIDHint);

    protected void DrawWireframe();
    protected Bounds OnHandleChanged(HandleDirection handle, Bounds boundsOnClick, Bounds newBounds);

    public enum HeightAxis
    {
        X = 0,
        Y = 1,
        Z = 2,
    }

}

}
