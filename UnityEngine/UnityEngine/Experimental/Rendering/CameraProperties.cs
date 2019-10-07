using System;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public struct CameraProperties
{
    public Plane GetCameraCullingPlane(int index);
    public Plane GetShadowCullingPlane(int index);
    public void SetCameraCullingPlane(int index, Plane plane);
    public void SetShadowCullingPlane(int index, Plane plane);

    public struct <_shadowCullPlanes>__FixedBuffer1
    {
        public float FixedElementField;

    }

    public struct <_cameraCullPlanes>__FixedBuffer2
    {
        public float FixedElementField;

    }

    public struct <layerCullDistances>__FixedBuffer3
    {
        public float FixedElementField;

    }

}

}
