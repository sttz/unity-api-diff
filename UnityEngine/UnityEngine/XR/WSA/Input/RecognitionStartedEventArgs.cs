using System;
using UnityEngine;

namespace UnityEngine.XR.WSA.Input
{

public struct RecognitionStartedEventArgs
{
    public Pose headPose { get; }
    public XR.WSA.Input.InteractionSource source { get; }
    public XR.WSA.Input.InteractionSourcePose sourcePose { get; }

}

}
