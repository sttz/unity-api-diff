using System;
using UnityEngine;

namespace UnityEngine.XR.WSA.Input
{

public struct InteractionSourceLocation
{
    public bool TryGetPosition(out Vector3 position);
    public bool TryGetVelocity(out Vector3 velocity);

}

}
