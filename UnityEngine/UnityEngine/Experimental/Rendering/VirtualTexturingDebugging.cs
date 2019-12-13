using System;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public static class VirtualTexturingDebugging
{
    static public string GetInfoDump();
    static public int GetNumHandles();
    static public void GrabHandleInfo(out Experimental.Rendering.VirtualTexturingDebugHandle debugHandle, int index);

}

}
