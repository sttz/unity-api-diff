using System;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public struct ShadowSplitData
{
    public int cullingPlaneCount;
    public Vector4 cullingSphere;

    public Plane GetCullingPlane(int index);
    public void SetCullingPlane(int index, Plane plane);

    public struct <_cullingPlanes>__FixedBuffer6
    {
        public float FixedElementField;

    }

}

}
