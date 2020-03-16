using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering.VirtualTexturing
{

public static class Debugging
{
    static public bool debugTilesEnabled { get; set; }
    static public bool flushEveryTickEnabled { get; set; }
    static public bool resolvingEnabled { get; set; }

    static public string GetInfoDump();
    static public int GetNumHandles();
    static public void GrabHandleInfo(out Handle debugHandle, int index);

    public struct Handle
    {
        public string group;
        public long handle;
        public Material material;
        public string name;
        public int numLayers;

    }

}

}
