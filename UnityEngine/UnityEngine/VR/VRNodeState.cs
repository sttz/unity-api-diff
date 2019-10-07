using System;
using UnityEngine;

namespace UnityEngine.VR
{

public struct VRNodeState
{
    public Vector3 acceleration { set; }
    public Vector3 angularAcceleration { set; }
    public Vector3 angularVelocity { set; }
    public VR.VRNode nodeType { get; set; }
    public Vector3 position { set; }
    public Quaternion rotation { set; }
    public bool tracked { get; set; }
    public ulong uniqueID { get; set; }
    public Vector3 velocity { set; }

    public bool TryGetAcceleration(out Vector3 acceleration);
    public bool TryGetAngularAcceleration(out Vector3 angularAcceleration);
    public bool TryGetAngularVelocity(out Vector3 angularVelocity);
    public bool TryGetPosition(out Vector3 position);
    public bool TryGetRotation(out Quaternion rotation);
    public bool TryGetVelocity(out Vector3 velocity);

}

}
