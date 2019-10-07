using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class ReflectionProbe : Behaviour
{
    static public Texture defaultTexture { get; }
    static public Vector4 defaultTextureHDRDecodeValues { get; }
    static public int maxBakedCubemapResolution { get; }
    static public int minBakedCubemapResolution { get; }

    static public event Action<Cubemap> defaultReflectionSet;
    static public event Action<ReflectionProbe, ReflectionProbeEvent> reflectionProbeChanged;

    static public bool BlendCubemap(Texture src, Texture dst, float blend, RenderTexture target);

    public Color backgroundColor { get; set; }
    public Texture bakedTexture { get; set; }
    public float blendDistance { get; set; }
    public Bounds bounds { get; }
    public bool boxProjection { get; set; }
    public Vector3 center { get; set; }
    public Rendering.ReflectionProbeClearFlags clearFlags { get; set; }
    public int cullingMask { get; set; }
    public Texture customBakedTexture { get; set; }
    public float farClipPlane { get; set; }
    public bool hdr { get; set; }
    public int importance { get; set; }
    public float intensity { get; set; }
    public Rendering.ReflectionProbeMode mode { get; set; }
    public float nearClipPlane { get; set; }
    public RenderTexture realtimeTexture { get; set; }
    public Rendering.ReflectionProbeRefreshMode refreshMode { get; set; }
    public int resolution { get; set; }
    public float shadowDistance { get; set; }
    public Vector3 size { get; set; }
    public Texture texture { get; }
    public Vector4 textureHDRDecodeValues { get; }
    public Rendering.ReflectionProbeTimeSlicingMode timeSlicingMode { get; set; }
    public Rendering.ReflectionProbeType type { get; set; }

    public ReflectionProbe();

    public bool IsFinishedRendering(int renderId);
    public int RenderProbe();
    public int RenderProbe(RenderTexture targetTexture);
    public void Reset();

    public enum ReflectionProbeEvent
    {
        ReflectionProbeAdded = 0,
        ReflectionProbeRemoved = 1,
    }

}

}
