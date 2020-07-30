using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public sealed class RayTracingAccelerationStructure : IDisposable
{
    public RayTracingAccelerationStructure();
    public RayTracingAccelerationStructure(RASSettings settings);

    public void AddInstance(Renderer targetRenderer, bool[] subMeshMask = null, bool[] subMeshTransparencyFlags = null, bool enableTriangleCulling = true, bool frontTriangleCounterClockwise = false, uint mask = 255);
    public void AddInstance(GraphicsBuffer aabbBuffer, uint numElements, Material material, bool isCutOff, bool enableTriangleCulling = true, bool frontTriangleCounterClockwise = false, uint mask = 255, bool reuseBounds = false);
    public void AddInstance(GraphicsBuffer aabbBuffer, uint numElements, Material material, Matrix4x4 instanceTransform, bool isCutOff, bool enableTriangleCulling = true, bool frontTriangleCounterClockwise = false, uint mask = 255, bool reuseBounds = false);
    public void Build();
    public void Build(Vector3 relativeOrigin);
    public void Dispose();
    public ulong GetSize();
    public void Release();
    public void Update();
    public void Update(Vector3 relativeOrigin);
    public void UpdateInstanceTransform(Renderer renderer);

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

    public enum RayTracingModeMask
    {
        Nothing = 0,
        Static = 2,
        DynamicTransform = 4,
        DynamicGeometry = 8,
        Everything = 14,
    }

}

}
