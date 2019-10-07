using System;
using UnityEngine;

namespace UnityEngine.XR
{

public static class InputTracking
{
    static public bool disablePositionalTracking { get; set; }

    static public event Action<XR.XRNodeState> nodeAdded;
    static public event Action<XR.XRNodeState> nodeRemoved;
    static public event Action<XR.XRNodeState> trackingAcquired;
    static public event Action<XR.XRNodeState> trackingLost;

    static public Vector3 GetLocalPosition(XR.XRNode node);
    static public Quaternion GetLocalRotation(XR.XRNode node);
    static public string GetNodeName(ulong uniqueId);
    static public void GetNodeStates(System.Collections.Generic.List<XR.XRNodeState> nodeStates);
    static public void Recenter();

}

}
