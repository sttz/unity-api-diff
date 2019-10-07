using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class LightmapSettings : Object
{
    static public ColorSpace bakedColorSpace { get; set; }
    static public LightmapData[] lightmaps { get; set; }
    static public LightmapsMode lightmapsMode { get; set; }
    static public LightmapsModeLegacy lightmapsModeLegacy { get; set; }
    static public LightProbes lightProbes { get; set; }

}

}
