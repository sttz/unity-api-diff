using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public static class ExternalGPUProfiler
{
    static public void BeginGPUCapture();
    static public void EndGPUCapture();
    static public bool IsAttached();

}

}
