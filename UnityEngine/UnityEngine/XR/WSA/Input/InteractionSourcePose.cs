using System;
using UnityEngine;

namespace UnityEngine.XR.WSA.Input
{

public struct InteractionSourcePose
{
    public XR.WSA.Input.InteractionSourcePositionAccuracy positionAccuracy { get; }

    public bool TryGetAngularVelocity(out Vector3 angularVelocity);
    public bool TryGetForward(out Vector3 forward, XR.WSA.Input.InteractionSourceNode node = 0);
    public bool TryGetPosition(out Vector3 position);
    public bool TryGetPosition(out Vector3 position, XR.WSA.Input.InteractionSourceNode node);
    public bool TryGetRight(out Vector3 right, XR.WSA.Input.InteractionSourceNode node = 0);
    public bool TryGetRotation(out Quaternion rotation, XR.WSA.Input.InteractionSourceNode node = 0);
    public bool TryGetUp(out Vector3 up, XR.WSA.Input.InteractionSourceNode node = 0);
    public bool TryGetVelocity(out Vector3 velocity);

}

}
