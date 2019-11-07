using System;
using UnityEngine;

namespace UnityEngine.XR.WSA.Input
{

public struct TappedEventArgs
{
    public Pose headPose { get; }
    public XR.WSA.Input.InteractionSource source { get; }
    public XR.WSA.Input.InteractionSourcePose sourcePose { get; }
    public int tapCount { get; }

}

}