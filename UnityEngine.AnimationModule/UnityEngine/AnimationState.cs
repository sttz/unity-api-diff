using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class AnimationState : TrackedReference
{
    public AnimationBlendMode blendMode { get; set; }
    public AnimationClip clip { get; }
    public bool enabled { get; set; }
    public int layer { get; set; }
    public float length { get; }
    public string name { get; set; }
    public float normalizedSpeed { get; set; }
    public float normalizedTime { get; set; }
    public float speed { get; set; }
    public float time { get; set; }
    public float weight { get; set; }
    public WrapMode wrapMode { get; set; }

    public AnimationState();

    public void AddMixingTransform(Transform mix);
    public void AddMixingTransform(Transform mix, bool recursive);
    public void RemoveMixingTransform(Transform mix);

}

}
