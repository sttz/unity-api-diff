using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class SystemInfo
{
    static public string unsupportedIdentifier = "n/a";

    static public float batteryLevel { get; }
    static public BatteryStatus batteryStatus { get; }
    static public int constantBufferOffsetAlignment { get; }
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
    static public bool hasMipMaxLevel { get; }
    static public HDRDisplaySupportFlags hdrDisplaySupportFlags { get; }
    static public int maxComputeBufferInputsCompute { get; }
    static public int maxComputeBufferInputsDomain { get; }
    static public int maxComputeBufferInputsFragment { get; }
    static public int maxComputeBufferInputsGeometry { get; }
    static public int maxComputeBufferInputsHull { get; }
    static public int maxComputeBufferInputsVertex { get; }
    static public int maxComputeWorkGroupSize { get; }
    static public int maxComputeWorkGroupSizeX { get; }
    static public int maxComputeWorkGroupSizeY { get; }
    static public int maxComputeWorkGroupSizeZ { get; }
    static public int maxCubemapSize { get; }
    static public int maxTextureSize { get; }
    static public bool minConstantBufferOffsetAlignment { get; }
    static public NPOTSupport npotSupport { get; }
    static public string operatingSystem { get; }
    static public OperatingSystemFamily operatingSystemFamily { get; }
    static public int processorCount { get; }
    static public int processorFrequency { get; }
    static public string processorType { get; }
    static public Rendering.RenderingThreadingMode renderingThreadingMode { get; }
    static public int supportedRandomWriteTargetCount { get; }
    static public int supportedRenderTargetCount { get; }
    static public bool supports2DArrayTextures { get; }
    static public bool supports32bitsIndexBuffer { get; }
    static public bool supports3DRenderTextures { get; }
    static public bool supports3DTextures { get; }
    static public bool supportsAccelerometer { get; }
    static public bool supportsAsyncCompute { get; }
    static public bool supportsAsyncGPUReadback { get; }
    static public bool supportsAudio { get; }
    static public bool supportsCompressed3DTextures { get; }
    static public bool supportsComputeShaders { get; }
    static public bool supportsConservativeRaster { get; }
    static public bool supportsCubemapArrayTextures { get; }
    static public bool supportsGeometryShaders { get; }
    static public bool supportsGPUFence { get; }
    static public bool supportsGpuRecorder { get; }
    static public bool supportsGraphicsFence { get; }
    static public bool supportsGyroscope { get; }
    static public bool supportsHardwareQuadTopology { get; }
    static public bool supportsImageEffects { get; }
    static public bool supportsInstancing { get; }
    static public bool supportsLocationService { get; }
    static public bool supportsMipStreaming { get; }
    static public bool supportsMotionVectors { get; }
    static public bool supportsMultisampleAutoResolve { get; }
    static public bool supportsMultisampled2DArrayTextures { get; }
    static public int supportsMultisampledTextures { get; }
    static public bool supportsMultiview { get; }
    static public bool supportsRawShadowDepthSampling { get; }
    static public bool supportsRayTracing { get; }
    static public bool supportsRenderTargetArrayIndexFromVertexShader { get; }
    static public bool supportsRenderTextures { get; }
    static public bool supportsRenderToCubemap { get; }
    static public bool supportsSeparatedRenderTargetsBlend { get; }
    static public bool supportsSetConstantBuffer { get; }
    static public bool supportsShadows { get; }
    static public bool supportsSparseTextures { get; }
    static public int supportsStencil { get; }
    static public bool supportsStoreAndResolveAction { get; }
    static public bool supportsTessellationShaders { get; }
    static public int supportsTextureWrapMirrorOnce { get; }
    static public bool supportsVertexPrograms { get; }
    static public bool supportsVibration { get; }
    static public int systemMemorySize { get; }
    static public bool usesLoadStoreActions { get; }
    static public bool usesReversedZBuffer { get; }

    static public Experimental.Rendering.GraphicsFormat GetCompatibleFormat(Experimental.Rendering.GraphicsFormat format, Experimental.Rendering.FormatUsage usage);
    static public Experimental.Rendering.GraphicsFormat GetGraphicsFormat(Experimental.Rendering.DefaultFormat format);
    static public int GetRenderTextureSupportedMSAASampleCount(RenderTextureDescriptor desc);
    static public bool IsFormatSupported(Experimental.Rendering.GraphicsFormat format, Experimental.Rendering.FormatUsage usage);
    static public bool SupportsBlendingOnRenderTextureFormat(RenderTextureFormat format);
    static public bool SupportsRandomWriteOnRenderTextureFormat(RenderTextureFormat format);
    static public bool SupportsRenderTextureFormat(RenderTextureFormat format);
    static public bool SupportsTextureFormat(TextureFormat format);
    static public bool SupportsVertexAttributeFormat(Rendering.VertexAttributeFormat format, int dimension);

    public SystemInfo();

}

}
