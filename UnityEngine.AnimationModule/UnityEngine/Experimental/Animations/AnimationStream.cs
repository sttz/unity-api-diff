using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.Animations
{

public struct AnimationStream
{
    public Vector3 angularVelocity { get; set; }
    public float deltaTime { get; }
    public int inputStreamCount { get; }
    public bool isHumanStream { get; }
    public bool isValid { get; }
    public Vector3 rootMotionPosition { get; }
    public Quaternion rootMotionRotation { get; }
    public Vector3 velocity { get; set; }

    public Experimental.Animations.AnimationHumanStream AsHuman();
    public Experimental.Animations.AnimationStream GetInputStream(int index);
    public float GetInputWeight(int index);

}

}
