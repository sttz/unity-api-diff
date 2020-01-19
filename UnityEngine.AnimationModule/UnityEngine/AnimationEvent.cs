using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class AnimationEvent
{
    public AnimationState animationState { get; }
    public AnimatorClipInfo animatorClipInfo { get; }
    public AnimatorStateInfo animatorStateInfo { get; }
    public string data { get; set; }
    public float floatParameter { get; set; }
    public string functionName { get; set; }
    public int intParameter { get; set; }
    public bool isFiredByAnimator { get; }
    public bool isFiredByLegacy { get; }
    public SendMessageOptions messageOptions { get; set; }
    public Object objectReferenceParameter { get; set; }
    public string stringParameter { get; set; }
    public float time { get; set; }

    public AnimationEvent();

}

}
