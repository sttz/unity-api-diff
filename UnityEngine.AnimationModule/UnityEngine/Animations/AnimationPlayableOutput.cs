using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Animations
{

public struct AnimationPlayableOutput : Playables.IPlayableOutput
{
    static public Animations.AnimationPlayableOutput Null { get; }

    static public Animations.AnimationPlayableOutput Create(Playables.PlayableGraph graph, string name, Animator target);

    public Playables.PlayableOutputHandle GetHandle();
    public Animator GetTarget();
    public void SetTarget(Animator value);

}

}
