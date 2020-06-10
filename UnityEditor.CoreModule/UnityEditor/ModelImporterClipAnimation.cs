using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public sealed class ModelImporterClipAnimation
{
    public float additiveReferencePoseFrame { get; set; }
    public UnityEditor.ClipAnimationInfoCurve[] curves { get; set; }
    public float cycleOffset { get; set; }
    public AnimationEvent[] events { get; set; }
    public float firstFrame { get; set; }
    public bool hasAdditiveReferencePose { get; set; }
    public bool heightFromFeet { get; set; }
    public float heightOffset { get; set; }
    public bool keepOriginalOrientation { get; set; }
    public bool keepOriginalPositionXZ { get; set; }
    public bool keepOriginalPositionY { get; set; }
    public float lastFrame { get; set; }
    public bool lockRootHeightY { get; set; }
    public bool lockRootPositionXZ { get; set; }
    public bool lockRootRotation { get; set; }
    public bool loop { get; set; }
    public bool loopPose { get; set; }
    public bool loopTime { get; set; }
    public bool maskNeedsUpdating { get; }
    public AvatarMask maskSource { get; set; }
    public UnityEditor.ClipAnimationMaskType maskType { get; set; }
    public bool mirror { get; set; }
    public string name { get; set; }
    public float rotationOffset { get; set; }
    public string takeName { get; set; }
    public WrapMode wrapMode { get; set; }

    public ModelImporterClipAnimation();

    public void ConfigureClipFromMask(AvatarMask mask);
    public void ConfigureMaskFromClip(AvatarMask mask);
    public bool Equals(object o);
    public int GetHashCode();

}

}
