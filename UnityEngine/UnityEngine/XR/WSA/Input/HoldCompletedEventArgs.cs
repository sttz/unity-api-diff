using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR.WSA.Input
{

public struct HoldCompletedEventArgs
{
    public Pose headPose { get; }
    public XR.WSA.Input.InteractionSource source { get; }
    public XR.WSA.Input.InteractionSourcePose sourcePose { get; }

}

}
