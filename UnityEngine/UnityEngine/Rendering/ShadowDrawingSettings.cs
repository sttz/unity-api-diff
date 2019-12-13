using System;
using UnityEngine;

namespace UnityEngine.Rendering
{

public struct ShadowDrawingSettings : IEquatable<Rendering.ShadowDrawingSettings>
{
    public Rendering.CullingResults cullingResults { get; set; }
    public int lightIndex { get; set; }
    public Rendering.ShadowSplitData splitData { get; set; }
    public bool useRenderingLayerMaskTest { get; set; }

    public ShadowDrawingSettings(Rendering.CullingResults cullingResults, int lightIndex);

    public bool Equals(Rendering.ShadowDrawingSettings other);
    public bool Equals(object obj);
    public int GetHashCode();

}

}