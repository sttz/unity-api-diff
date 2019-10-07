using System;
using UnityEngine;

namespace UnityEngine.Rendering
{

public enum RenderingThreadingMode
{
    Direct = 0,
    SingleThreaded = 1,
    MultiThreaded = 2,
    LegacyJobified = 3,
    NativeGraphicsJobs = 4,
    NativeGraphicsJobsWithoutRenderThread = 5,
}

}
