using System;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public sealed class RayTracingAccelerationStructure : IDisposable
{
    public RayTracingAccelerationStructure(RASSettings settings);
    public RayTracingAccelerationStructure();

    public void AddInstance(Renderer targetRenderer, bool[] subMeshMask = null, bool[] subMeshTransparencyFlags = null, bool enableTriangleCulling = true, bool frontTriangleCounterClockwise = false, uint mask = 255);
    public void Build();
    public void Dispose();
    public ulong GetSize();
    public void Release();
    public void Update();
    public void UpdateInstanceTransform(Renderer renderer);

    public enum RayTracingModeMask
    {
        Nothing = 0,
        Static = 2,
        DynamicTransform = 4,
        DynamicGeometry = 8,
        Everything = 14,
    }

    public enum ManagementMode
    {
        Manual = 0,
        Automatic = 1,
    }

    public struct RASSettings
    {
        public int layerMask;
        public ManagementMode managementMode;
        public RayTracingModeMask rayTracingModeMask;

        public RASSettings(ManagementMode sceneManagementMode, RayTracingModeMask rayTracingModeMask, int layerMask);

    }

}

}
