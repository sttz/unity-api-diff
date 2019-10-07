using System;
using UnityEngine;

namespace UnityEngine.XR.WSA.Input
{

public struct InteractionSourceProperties
{
    public XR.WSA.Input.InteractionSourceLocation location { get; }
    public Vector3 sourceLossMitigationDirection { get; }
    public double sourceLossRisk { get; }
    public XR.WSA.Input.InteractionSourcePose sourcePose { get; }

}

}
