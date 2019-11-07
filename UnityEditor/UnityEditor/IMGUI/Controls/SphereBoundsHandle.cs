using System;
using UnityEngine;

namespace UnityEditor.IMGUI.Controls
{

public class SphereBoundsHandle : UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle
{
    public float radius { get; set; }

    public SphereBoundsHandle(int controlIDHint);
    public SphereBoundsHandle();

    protected void DrawWireframe();
    protected Bounds OnHandleChanged(HandleDirection handle, Bounds boundsOnClick, Bounds newBounds);

}

}
