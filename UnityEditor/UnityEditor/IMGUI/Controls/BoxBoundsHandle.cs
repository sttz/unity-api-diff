using System;
using UnityEngine;

namespace UnityEditor.IMGUI.Controls
{

public class BoxBoundsHandle : UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle
{
    public Vector3 size { get; set; }

    public BoxBoundsHandle(int controlIDHint);
    public BoxBoundsHandle();

    protected void DrawWireframe();

}

}
