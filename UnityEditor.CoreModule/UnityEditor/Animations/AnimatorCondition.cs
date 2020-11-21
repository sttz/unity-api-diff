using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Animations
{

public struct AnimatorCondition
{
    public UnityEditor.Animations.AnimatorConditionMode mode { get; set; }
    public string parameter { get; set; }
    public float threshold { get; set; }

}

}
