using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering.VirtualTexturing
{

public static class System
{
    static public int AllMips = 2147483647;

    static public void ApplyVirtualTexturingSettings(Rendering.VirtualTexturing.VirtualTexturingSettings settings);
    static public void GetTextureStackSize(Material mat, int stackNameId, out int width, out int height);
    static public void RequestRegion(Material mat, int stackNameId, Rect r, int mipMap, int numMips);
    static public void Update();

}

}
