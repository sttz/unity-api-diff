using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class SystemInfo
{
    static public string unsupportedIdentifier = "n/a";

    static public float batteryLevel { get; }
    static public BatteryStatus batteryStatus { get; }
    static public Rendering.CopyTextureSupport copyTextureSupport { get; }
    static public string deviceModel { get; }
    static public string deviceName { get; }
    static public DeviceType deviceType { get; }
    static public string deviceUniqueIdentifier { get; }
    static public int graphicsDeviceID { get; }
    static public string graphicsDeviceName { get; }
    static public Rendering.GraphicsDeviceType graphicsDeviceType { get; }
    static public string graphicsDeviceVendor { get; }
    static public int graphicsDeviceVendorID { get; }
    static public string graphicsDeviceVersion { get; }
    static public int graphicsMemorySize { get; }
    static public bool graphicsMultiThreaded { get; }
    static public int graphicsPixelFillrate { get; }
    static public int graphicsShaderLevel { get; }
    static public bool graphicsUVStartsAtTop { get; }
    static public bool hasDynamicUniformArrayIndexingInFragmentShaders { get; }
    static public bool hasHiddenSurfaceRemovalOnGPU { get; }
    static public int maxCubemapSize { get; }
    static public int maxTextureSize { get; }
    static public NPOTSupport npotSupport { get; }
    static public string operatingSystem { get; }
    static public OperatingSystemFamily operatingSystemFamily { get; }
    static public int processorCount { get; }
    static public int processorFrequency { get; }
    static public string processorType { get; }
    static public int supportedRenderTargetCount { get; }
    static public bool supports2DArrayTextures { get; }
    static public bool supports32bitsIndexBuffer { get; }
    static public bool supports3DRenderTextures { get; }
    static public bool supports3DTextures { get; }
    static public bool supportsAccelerometer { get; }
    static public bool supportsAsyncCompute { get; }
    static public bool supportsAsyncGPUReadback { get; }
    static public bool supportsAudio { get; }
    static public bool supportsComputeShaders { get; }
    static public bool supportsCubemapArrayTextures { get; }
    static public bool supportsGPUFence { get; }
    static public bool supportsGyroscope { get; }
    static public bool supportsHardwareQuadTopology { get; }
    static public bool supportsImageEffects { get; }
    static public bool supportsInstancing { get; }
    static public bool supportsLocationService { get; }
    static public bool supportsMipStreaming { get; }
    static public bool supportsMotionVectors { get; }
    static public bool supportsMultisampleAutoResolve { get; }
    static public int supportsMultisampledTextures { get; }
    static public bool supportsRawShadowDepthSampling { get; }
    static public bool supportsRenderTextures { get; }
    static public bool supportsRenderToCubemap { get; }
    static public bool supportsSeparatedRenderTargetsBlend { get; }
    static public bool supportsShadows { get; }
    static public bool supportsSparseTextures { get; }
    static public int supportsStencil { get; }
    static public int supportsTextureWrapMirrorOnce { get; }
    static public bool supportsVertexPrograms { get; }
    static public bool supportsVibration { get; }
    static public int systemMemorySize { get; }
    static public bool usesReversedZBuffer { get; }

    static public bool IsFormatSupported(Experimental.Rendering.GraphicsFormat format, Experimental.Rendering.FormatUsage usage);
    static public bool SupportsBlendingOnRenderTextureFormat(RenderTextureFormat format);
    static public bool SupportsRenderTextureFormat(RenderTextureFormat format);
    static public bool SupportsTextureFormat(TextureFormat format);

    public SystemInfo();

}

}
