using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Animations
{

public class BlendTree : Motion
{
    public string blendParameter { get; set; }
    public string blendParameterY { get; set; }
    public UnityEditor.Animations.BlendTreeType blendType { get; set; }
    public UnityEditor.Animations.ChildMotion[] children { get; set; }
    public float maxThreshold { get; set; }
    public float minThreshold { get; set; }
    public bool useAutomaticThresholds { get; set; }

    public BlendTree();

    public void AddChild(Motion motion);
    public void AddChild(Motion motion, Vector2 position);
    public void AddChild(Motion motion, float threshold);
    public UnityEditor.Animations.BlendTree CreateBlendTreeChild(Vector2 position);
    public UnityEditor.Animations.BlendTree CreateBlendTreeChild(float threshold);
    public void RemoveChild(int index);

}

}
