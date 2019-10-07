using System;
using UnityEngine;

namespace UnityEngine.XR.WSA
{

public struct SurfaceData
{
    public bool bakeCollider;
    public XR.WSA.SurfaceId id;
    public XR.WSA.WorldAnchor outputAnchor;
    public MeshCollider outputCollider;
    public MeshFilter outputMesh;
    public float trianglesPerCubicMeter;

    public SurfaceData(XR.WSA.SurfaceId _id, MeshFilter _outputMesh, XR.WSA.WorldAnchor _outputAnchor, MeshCollider _outputCollider, float _trianglesPerCubicMeter, bool _bakeCollider);

}

}
