using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Animations
{

public class AnimatorStateTransition : UnityEditor.Animations.AnimatorTransitionBase
{
    public bool canTransitionToSelf { get; set; }
    public float duration { get; set; }
    public float exitTime { get; set; }
    public bool hasExitTime { get; set; }
    public bool hasFixedDuration { get; set; }
    public UnityEditor.Animations.TransitionInterruptionSource interruptionSource { get; set; }
    public float offset { get; set; }
    public bool orderedInterruption { get; set; }

    public AnimatorStateTransition();

}

}
