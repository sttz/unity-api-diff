using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Animations
{

public struct AnimationScriptPlayable : Animations.IAnimationJobPlayable, Playables.IPlayable, IEquatable<Animations.AnimationScriptPlayable>
{
    static public Animations.AnimationScriptPlayable Null { get; }

    static public Animations.AnimationScriptPlayable Create<T>(Playables.PlayableGraph graph, T jobData, int inputCount = 0);

    public bool Equals(Animations.AnimationScriptPlayable other);
    public Playables.PlayableHandle GetHandle();
    public T GetJobData<T>();
    public bool GetProcessInputs();
    public void SetJobData<T>(T jobData);
    public void SetProcessInputs(bool value);

}

}
