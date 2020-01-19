using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class AnimationClip : Motion
{
    public bool empty { get; }
    public AnimationEvent[] events { get; set; }
    public float frameRate { get; set; }
    public bool hasGenericRootTransform { get; }
    public bool hasMotionCurves { get; }
    public bool hasMotionFloatCurves { get; }
    public bool hasRootCurves { get; }
    public bool humanMotion { get; }
    public bool legacy { get; set; }
    public float length { get; }
    public Bounds localBounds { get; set; }
    public WrapMode wrapMode { get; set; }

    public AnimationClip();

    public void AddEvent(AnimationEvent evt);
    public void ClearCurves();
    public void EnsureQuaternionContinuity();
    public void SampleAnimation(GameObject go, float time);
    public void SetCurve(string relativePath, Type type, string propertyName, AnimationCurve curve);

}

}
