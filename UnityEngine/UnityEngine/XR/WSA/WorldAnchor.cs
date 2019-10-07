using System;
using UnityEngine;

namespace UnityEngine.XR.WSA
{

public class WorldAnchor : Component
{
    public bool isLocated { get; }

    public event OnTrackingChangedDelegate OnTrackingChanged;

    public IntPtr GetNativeSpatialAnchorPtr();
    public void SetNativeSpatialAnchorPtr(IntPtr spatialAnchorPtr);

    public delegate void OnTrackingChangedDelegate(XR.WSA.WorldAnchor worldAnchor, bool located);

}

}
