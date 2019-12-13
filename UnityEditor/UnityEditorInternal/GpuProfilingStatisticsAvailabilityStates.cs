using System;
using UnityEngine;

namespace UnityEditorInternal
{

public enum GpuProfilingStatisticsAvailabilityStates
{
    Gathered = 1,
    Enabled = 2,
    Supported = 4,
    NotSupportedWithEditorProfiling = 8,
    NotSupportedWithLegacyGfxJobs = 16,
    NotSupportedWithNativeGfxJobs = 32,
    NotSupportedByDevice = 64,
    NotSupportedByGraphicsAPI = 128,
    NotSupportedDueToFrameTimingStatsAndDisjointTimerQuery = 256,
    NotSupportedWithVulkan = 512,
    NotSupportedWithMetal = 1024,
}

}
