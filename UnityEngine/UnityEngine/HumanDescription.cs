using System;
using UnityEngine;

namespace UnityEngine
{

public struct HumanDescription
{
    public HumanBone[] human;
    public SkeletonBone[] skeleton;

    public float armStretch { get; set; }
    public float feetSpacing { get; set; }
    public bool hasTranslationDoF { get; set; }
    public float legStretch { get; set; }
    public float lowerArmTwist { get; set; }
    public float lowerLegTwist { get; set; }
    public float upperArmTwist { get; set; }
    public float upperLegTwist { get; set; }

}

}
