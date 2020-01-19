using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR.WSA.Input
{

public struct InteractionSourceState
{
    public bool anyPressed { get; }
    public bool grasped { get; }
    public Pose headPose { get; }
    public Ray headRay { get; }
    public bool menuPressed { get; }
    public bool pressed { get; }
    public XR.WSA.Input.InteractionSourceProperties properties { get; }
    public bool selectPressed { get; }
    public float selectPressedAmount { get; }
    public XR.WSA.Input.InteractionSource source { get; }
    public XR.WSA.Input.InteractionSourcePose sourcePose { get; }
    public Vector2 thumbstickPosition { get; }
    public bool thumbstickPressed { get; }
    public Vector2 touchpadPosition { get; }
    public bool touchpadPressed { get; }
    public bool touchpadTouched { get; }

}

}
