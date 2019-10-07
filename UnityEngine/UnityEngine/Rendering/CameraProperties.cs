using System;
using UnityEngine;

namespace UnityEngine.Rendering
{

public struct CameraProperties : IEquatable<Rendering.CameraProperties>
{
    public bool Equals(Rendering.CameraProperties other);
    public bool Equals(object obj);
    public Plane GetCameraCullingPlane(int index);
    public int GetHashCode();
    public Plane GetShadowCullingPlane(int index);
    public void SetCameraCullingPlane(int index, Plane plane);
    public void SetShadowCullingPlane(int index, Plane plane);

    public struct <m_ShadowCullPlanes>e__FixedBuffer
    {
        public byte FixedElementField;

    }

    public struct <m_CameraCullPlanes>e__FixedBuffer
    {
        public byte FixedElementField;

    }

    public struct <layerCullDistances>e__FixedBuffer
    {
        public float FixedElementField;

    }

}

}
