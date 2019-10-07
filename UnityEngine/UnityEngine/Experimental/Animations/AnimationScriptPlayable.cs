using System;
using UnityEngine;

namespace UnityEngine.Experimental.Animations
{

public struct AnimationScriptPlayable : Experimental.Animations.IAnimationJobPlayable, IEquatable<Experimental.Animations.AnimationScriptPlayable>, Playables.IPlayable
{
    static public Experimental.Animations.AnimationScriptPlayable Null { get; }

    static public Experimental.Animations.AnimationScriptPlayable Create(Playables.PlayableGraph graph, T jobData, int inputCount = 0);

    public bool Equals(Experimental.Animations.AnimationScriptPlayable other);
    public Playables.PlayableHandle GetHandle();
    public T GetJobData();
    public bool GetProcessInputs();
    public void SetJobData(T jobData);
    public void SetProcessInputs(bool value);

}

}
