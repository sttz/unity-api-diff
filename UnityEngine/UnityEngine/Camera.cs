using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class Camera : Behaviour
{
    static public CameraCallback onPostRender;
    static public CameraCallback onPreCull;
    static public CameraCallback onPreRender;

    static public Camera[] allCameras { get; }
    static public int allCamerasCount { get; }
    static public Camera current { get; }
    static public Camera main { get; }
    static public Camera mainCamera { get; }

    static public void CalculateProjectionMatrixFromPhysicalProperties(out Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, GateFitParameters gateFitParameters = null);
    static public float FocalLengthToFOV(float focalLength, float sensorSize);
    static public float FOVToFocalLength(float fov, float sensorSize);
    static public int GetAllCameras(Camera[] cameras);
    static public void SetupCurrent(Camera cur);

    public RenderTexture activeTexture { get; }
    public RenderingPath actualRenderingPath { get; }
    public bool allowDynamicResolution { get; set; }
    public bool allowHDR { get; set; }
    public bool allowMSAA { get; set; }
    public bool areVRStereoViewMatricesWithinSingleCullTolerance { get; }
    public float aspect { get; set; }
    public Color backgroundColor { get; set; }
    public Matrix4x4 cameraToWorldMatrix { get; }
    public CameraType cameraType { get; set; }
    public CameraClearFlags clearFlags { get; set; }
    public bool clearStencilAfterLightingPass { get; set; }
    public int commandBufferCount { get; }
    public int cullingMask { get; set; }
    public Matrix4x4 cullingMatrix { get; set; }
    public float depth { get; set; }
    public DepthTextureMode depthTextureMode { get; set; }
    public int eventMask { get; set; }
    public float far { get; set; }
    public float farClipPlane { get; set; }
    public float fieldOfView { get; set; }
    public float focalLength { get; set; }
    public bool forceIntoRenderTexture { get; set; }
    public float fov { get; set; }
    public GateFitMode gateFit { get; set; }
    public bool hdr { get; set; }
    public bool isOrthoGraphic { get; set; }
    public float[] layerCullDistances { get; set; }
    public bool layerCullSpherical { get; set; }
    public Vector2 lensShift { get; set; }
    public float near { get; set; }
    public float nearClipPlane { get; set; }
    public Matrix4x4 nonJitteredProjectionMatrix { get; set; }
    public Rendering.OpaqueSortMode opaqueSortMode { get; set; }
    public bool orthographic { get; set; }
    public float orthographicSize { get; set; }
    public int pixelHeight { get; }
    public Rect pixelRect { get; set; }
    public int pixelWidth { get; }
    public Matrix4x4 previousViewProjectionMatrix { get; }
    public Matrix4x4 projectionMatrix { get; set; }
    public Rect rect { get; set; }
    public RenderingPath renderingPath { get; set; }
    public int scaledPixelHeight { get; }
    public int scaledPixelWidth { get; }
    public SceneManagement.Scene scene { get; set; }
    public Vector2 sensorSize { get; set; }
    public MonoOrStereoscopicEye stereoActiveEye { get; }
    public float stereoConvergence { get; set; }
    public bool stereoEnabled { get; }
    public bool stereoMirrorMode { get; set; }
    public float stereoSeparation { get; set; }
    public StereoTargetEyeMask stereoTargetEye { get; set; }
    public int targetDisplay { get; set; }
    public RenderTexture targetTexture { get; set; }
    public Vector3 transparencySortAxis { get; set; }
    public TransparencySortMode transparencySortMode { get; set; }
    public bool useJitteredProjectionMatrixForTransparentRendering { get; set; }
    public bool useOcclusionCulling { get; set; }
    public bool usePhysicalProperties { get; set; }
    public Vector3 velocity { get; }
    public Matrix4x4 worldToCameraMatrix { get; set; }

    public Camera();

    public void AddCommandBuffer(Rendering.CameraEvent evt, Rendering.CommandBuffer buffer);
    public void AddCommandBufferAsync(Rendering.CameraEvent evt, Rendering.CommandBuffer buffer, Rendering.ComputeQueueType queueType);
    public void CalculateFrustumCorners(Rect viewport, float z, MonoOrStereoscopicEye eye, Vector3[] outCorners);
    public Matrix4x4 CalculateObliqueMatrix(Vector4 clipPlane);
    public void CopyFrom(Camera other);
    public void CopyStereoDeviceProjectionMatrixToNonJittered(StereoscopicEye eye);
    public void DoClear();
    public Rendering.CommandBuffer[] GetCommandBuffers(Rendering.CameraEvent evt);
    public float GetScreenHeight();
    public float GetScreenWidth();
    public Matrix4x4 GetStereoNonJitteredProjectionMatrix(StereoscopicEye eye);
    public Matrix4x4[] GetStereoProjectionMatrices();
    public Matrix4x4 GetStereoProjectionMatrix(StereoscopicEye eye);
    public Matrix4x4[] GetStereoViewMatrices();
    public Matrix4x4 GetStereoViewMatrix(StereoscopicEye eye);
    public void RemoveAllCommandBuffers();
    public void RemoveCommandBuffer(Rendering.CameraEvent evt, Rendering.CommandBuffer buffer);
    public void RemoveCommandBuffers(Rendering.CameraEvent evt);
    public void Render();
    public void RenderDontRestore();
    public bool RenderToCubemap(Cubemap cubemap, int faceMask);
    public bool RenderToCubemap(Cubemap cubemap);
    public bool RenderToCubemap(RenderTexture cubemap, int faceMask);
    public bool RenderToCubemap(RenderTexture cubemap);
    public bool RenderToCubemap(RenderTexture cubemap, int faceMask, MonoOrStereoscopicEye stereoEye);
    public void RenderWithShader(Shader shader, string replacementTag);
    public void Reset();
    public void ResetAspect();
    public void ResetCullingMatrix();
    public void ResetFieldOfView();
    public void ResetProjectionMatrix();
    public void ResetReplacementShader();
    public void ResetStereoProjectionMatrices();
    public void ResetStereoViewMatrices();
    public void ResetTransparencySortSettings();
    public void ResetWorldToCameraMatrix();
    public Ray ScreenPointToRay(Vector3 pos, MonoOrStereoscopicEye eye);
    public Ray ScreenPointToRay(Vector3 pos);
    public Vector3 ScreenToViewportPoint(Vector3 position);
    public Vector3 ScreenToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye);
    public Vector3 ScreenToWorldPoint(Vector3 position);
    public void SetReplacementShader(Shader shader, string replacementTag);
    public void SetStereoProjectionMatrices(Matrix4x4 leftMatrix, Matrix4x4 rightMatrix);
    public void SetStereoProjectionMatrix(StereoscopicEye eye, Matrix4x4 matrix);
    public void SetStereoViewMatrices(Matrix4x4 leftMatrix, Matrix4x4 rightMatrix);
    public void SetStereoViewMatrix(StereoscopicEye eye, Matrix4x4 matrix);
    public void SetTargetBuffers(RenderBuffer colorBuffer, RenderBuffer depthBuffer);
    public void SetTargetBuffers(RenderBuffer[] colorBuffer, RenderBuffer depthBuffer);
    public Ray ViewportPointToRay(Vector3 pos, MonoOrStereoscopicEye eye);
    public Ray ViewportPointToRay(Vector3 pos);
    public Vector3 ViewportToScreenPoint(Vector3 position);
    public Vector3 ViewportToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye);
    public Vector3 ViewportToWorldPoint(Vector3 position);
    public Vector3 WorldToScreenPoint(Vector3 position, MonoOrStereoscopicEye eye);
    public Vector3 WorldToScreenPoint(Vector3 position);
    public Vector3 WorldToViewportPoint(Vector3 position, MonoOrStereoscopicEye eye);
    public Vector3 WorldToViewportPoint(Vector3 position);

    public enum GateFitMode
    {
        Vertical = 1,
        Horizontal = 2,
        Fill = 3,
        Overscan = 4,
        None = 0,
    }

    public struct GateFitParameters
    {
        public float aspect { get; set; }
        public GateFitMode mode { get; set; }

        public GateFitParameters(GateFitMode mode, float aspect);

    }

    public enum StereoscopicEye
    {
        Left = 0,
        Right = 1,
    }

    public enum MonoOrStereoscopicEye
    {
        Left = 0,
        Right = 1,
        Mono = 2,
    }

    public delegate void CameraCallback(Camera cam);

}

}
