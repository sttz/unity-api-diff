using System;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public static class GraphicsDeviceSettings
{
    static public Experimental.Rendering.GraphicsJobsSyncPoint graphicsJobsSyncPoint { get; set; }
    static public Experimental.Rendering.WaitForPresentSyncPoint waitForPresentSyncPoint { get; set; }

}

}
