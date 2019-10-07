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

    public struct <m_ShadowCullPlanes>__FixedBuffer0
    {
        public byte FixedElementField;

    }

    public struct <m_CameraCullPlanes>__FixedBuffer1
    {
        public byte FixedElementField;

    }

    public struct <layerCullDistances>__FixedBuffer2
    {
        public float FixedElementField;

    }

}

}
