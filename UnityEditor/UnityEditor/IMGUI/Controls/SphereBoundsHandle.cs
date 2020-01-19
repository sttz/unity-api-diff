using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.IMGUI.Controls
{

public class SphereBoundsHandle : UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle
{
    public float radius { get; set; }

    public SphereBoundsHandle();
    public SphereBoundsHandle(int controlIDHint);

    protected void DrawWireframe();
    protected Bounds OnHandleChanged(HandleDirection handle, Bounds boundsOnClick, Bounds newBounds);

}

}
