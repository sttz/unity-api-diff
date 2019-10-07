using System;
using UnityEngine;

namespace UnityEngine.Rendering
{

public struct FilteringSettings : IEquatable<Rendering.FilteringSettings>
{
    static public Rendering.FilteringSettings defaultValue { get; }

    public bool excludeMotionVectorObjects { get; set; }
    public int layerMask { get; set; }
    public uint renderingLayerMask { get; set; }
    public Rendering.RenderQueueRange renderQueueRange { get; set; }
    public Rendering.SortingLayerRange sortingLayerRange { get; set; }

    public FilteringSettings(Nullable<Rendering.RenderQueueRange> renderQueueRange = null, int layerMask = -1, uint renderingLayerMask = 4294967295, int excludeMotionVectorObjects = 0);

    public bool Equals(Rendering.FilteringSettings other);
    public bool Equals(object obj);
    public int GetHashCode();

}

}
