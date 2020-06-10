using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.IMGUI.Controls
{

public class BoxBoundsHandle : UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle
{
    public Vector3 size { get; set; }

    public BoxBoundsHandle();
    public BoxBoundsHandle(int controlIDHint);

    protected void DrawWireframe();

}

}
