using System;
using UnityEngine;

namespace UnityEngine.XR
{

public class XRDisplaySubsystem : IntegratedSubsystem<XR.XRDisplaySubsystemDescriptor>
{
    static public event Action<bool> displayFocusChanged;

    public bool contentProtectionEnabled { get; set; }
    public bool disableLegacyRenderer { get; set; }
    public bool displayOpaque { get; }
    public ReprojectionMode reprojectionMode { get; set; }
    public bool singlePassRenderingDisabled { get; set; }

    public XRDisplaySubsystem();

    public bool AddGraphicsThreadMirrorViewBlit(Rendering.CommandBuffer cmd, bool allowGraphicsStateInvalidate);
    public bool AddGraphicsThreadMirrorViewBlit(Rendering.CommandBuffer cmd, bool allowGraphicsStateInvalidate, int mode);
    public void GetCullingParameters(Camera camera, int cullingPassIndex, out Rendering.ScriptableCullingParameters scriptableCullingParameters);
    public bool GetMirrorViewBlitDesc(RenderTexture mirrorRt, out XRMirrorViewBlitDesc outDesc);
    public bool GetMirrorViewBlitDesc(RenderTexture mirrorRt, out XRMirrorViewBlitDesc outDesc, int mode);
    public int GetPreferredMirrorBlitMode();
    public void GetRenderPass(int renderPassIndex, out XRRenderPass renderPass);
    public int GetRenderPassCount();
    public void SetFocusPlane(Vector3 point, Vector3 normal, Vector3 velocity);
    public bool TryGetAppGPUTimeLastFrame(out float gpuTimeLastFrame);
    public bool TryGetCompositorGPUTimeLastFrame(out float gpuTimeLastFrameCompositor);
    public bool TryGetDisplayRefreshRate(out float displayRefreshRate);
    public bool TryGetDroppedFrameCount(out int droppedFrameCount);
    public bool TryGetFramePresentCount(out int framePresentCount);
    public bool TryGetMotionToPhoton(out float motionToPhoton);

    public enum ReprojectionMode
    {
        Unspecified = 0,
        PositionAndOrientation = 1,
        OrientationOnly = 2,
        None = 3,
    }

    public struct XRRenderParameter
    {
        public Mesh occlusionMesh;
        public Matrix4x4 projection;
        public int textureArraySlice;
        public Matrix4x4 view;
        public Rect viewport;

    }

    public struct XRRenderPass
    {
        public int cullingPassIndex;
        public int renderPassIndex;
        public Rendering.RenderTargetIdentifier renderTarget;
        public RenderTextureDescriptor renderTargetDesc;
        public bool shouldFillOutDepth;

        public void GetRenderParameter(Camera camera, int renderParameterIndex, out XRRenderParameter renderParameter);
        public int GetRenderParameterCount();

    }

    public struct XRBlitParams
    {
        public Rect destRect;
        public Rect srcRect;
        public RenderTexture srcTex;
        public int srcTexArraySlice;

    }

    public struct XRMirrorViewBlitDesc
    {
        public int blitParamsCount;
        public bool nativeBlitAvailable;
        public bool nativeBlitInvalidStates;

        public void GetBlitParameter(int blitParameterIndex, out XRBlitParams blitParameter);

    }

}

}
