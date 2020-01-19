using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR.WSA
{

public sealed class SurfaceObserver : IDisposable
{
    public SurfaceObserver();

    public void Dispose();
    public bool RequestMeshAsync(XR.WSA.SurfaceData dataRequest, SurfaceDataReadyDelegate onDataReady);
    public void SetVolumeAsAxisAlignedBox(Vector3 origin, Vector3 extents);
    public void SetVolumeAsFrustum(Plane[] planes);
    public void SetVolumeAsOrientedBox(Vector3 origin, Vector3 extents, Quaternion orientation);
    public void SetVolumeAsSphere(Vector3 origin, float radiusMeters);
    public void Update(SurfaceChangedDelegate onSurfaceChanged);

    public delegate void SurfaceChangedDelegate(XR.WSA.SurfaceId surfaceId, XR.WSA.SurfaceChange changeType, Bounds bounds, DateTime updateTime);

    public delegate void SurfaceDataReadyDelegate(XR.WSA.SurfaceData bakedData, bool outputWritten, float elapsedBakeTimeSeconds);

}

}
