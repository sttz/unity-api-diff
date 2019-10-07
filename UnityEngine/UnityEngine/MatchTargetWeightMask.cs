using System;
using UnityEngine;

namespace UnityEngine
{

public struct MatchTargetWeightMask
{
    public Vector3 positionXYZWeight { get; set; }
    public float rotationWeight { get; set; }

    public MatchTargetWeightMask(Vector3 positionXYZWeight, float rotationWeight);

}

}
