using System;
using UnityEngine;

namespace UnityEngine.XR.WSA.Input
{

public struct NavigationUpdatedEventArgs
{
    public Pose headPose { get; }
    public Vector3 normalizedOffset { get; }
    public XR.WSA.Input.InteractionSource source { get; }
    public XR.WSA.Input.InteractionSourcePose sourcePose { get; }

}

}
