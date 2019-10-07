using System;
using UnityEngine;

namespace UnityEngine.Animations
{

public struct AnimationClipPlayable : Playables.IPlayable, IEquatable<Animations.AnimationClipPlayable>
{
    static public Animations.AnimationClipPlayable Create(Playables.PlayableGraph graph, AnimationClip clip);

    public bool Equals(Animations.AnimationClipPlayable other);
    public AnimationClip GetAnimationClip();
    public bool GetApplyFootIK();
    public bool GetApplyPlayableIK();
    public Playables.PlayableHandle GetHandle();
    public void SetApplyFootIK(bool value);
    public void SetApplyPlayableIK(bool value);

}

}
