using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR.WSA.Input
{

public struct ManipulationCompletedEventArgs
{
    public Vector3 cumulativeDelta { get; }
    public Pose headPose { get; }
    public XR.WSA.Input.InteractionSource source { get; }
    public XR.WSA.Input.InteractionSourcePose sourcePose { get; }

}

}
