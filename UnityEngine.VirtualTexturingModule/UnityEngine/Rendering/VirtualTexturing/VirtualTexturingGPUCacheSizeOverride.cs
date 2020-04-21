using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering.VirtualTexturing
{

public struct VirtualTexturingGPUCacheSizeOverride
{
    public Experimental.Rendering.GraphicsFormat format;
    public uint sizeInMegaBytes;
    public Rendering.VirtualTexturing.VirtualTexturingCacheUsage usage;

}

}
