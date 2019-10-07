using System;
using UnityEngine;

namespace UnityEngine.VR
{

public static class InputTracking
{
    static public bool disablePositionalTracking { get; set; }

    static public Vector3 GetLocalPosition(VR.VRNode node);
    static public string GetNodeName(ulong uniqueID);
    static public void GetNodeStates(System.Collections.Generic.List<VR.VRNodeState> nodeStates);
    static public void Recenter();

}

}
