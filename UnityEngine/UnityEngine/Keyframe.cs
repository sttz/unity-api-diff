using System;
using UnityEngine;

namespace UnityEngine
{

public struct Keyframe
{
    public float inTangent { get; set; }
    public float inWeight { get; set; }
    public float outTangent { get; set; }
    public float outWeight { get; set; }
    public int tangentMode { get; set; }
    public float time { get; set; }
    public float value { get; set; }
    public WeightedMode weightedMode { get; set; }

    public Keyframe(float time, float value);
    public Keyframe(float time, float value, float inTangent, float outTangent);
    public Keyframe(float time, float value, float inTangent, float outTangent, float inWeight, float outWeight);

}

}
