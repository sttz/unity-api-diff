using System;
using UnityEngine;

namespace UnityEngine.XR.Provider
{

public static class XRStats
{
    static public bool TryGetStat(Experimental.IntegratedSubsystem xrSubsystem, string tag, out float value);

}

}
