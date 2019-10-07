using System;
using UnityEngine;

namespace UnityEngineInternal
{

public static class GIDebugVisualisation
{
    static public bool cycleMode { get; }
    static public bool pauseCycleMode { get; }
    static public UnityEngineInternal.GITextureType texType { get; set; }

    static public void CycleSkipInstances(int skip);
    static public void CycleSkipSystems(int skip);
    static public void PauseCycleMode();
    static public void PlayCycleMode();
    static public void ResetRuntimeInputTextures();
    static public void StopCycleMode();

}

}
