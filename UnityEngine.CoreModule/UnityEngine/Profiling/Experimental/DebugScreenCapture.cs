using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Profiling.Experimental
{

public struct DebugScreenCapture
{
    public int height { get; set; }
    public TextureFormat imageFormat { get; set; }
    public Unity.Collections.NativeArray<byte> rawImageDataReference { get; set; }
    public int width { get; set; }

}

}
