using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Animations
{

public struct AnimationMixerPlayable : Playables.IPlayable, IEquatable<Animations.AnimationMixerPlayable>
{
    static public Animations.AnimationMixerPlayable Null { get; }

    static public Animations.AnimationMixerPlayable Create(Playables.PlayableGraph graph, int inputCount = 0, bool normalizeWeights = false);

    public bool Equals(Animations.AnimationMixerPlayable other);
    public Playables.PlayableHandle GetHandle();

}

}
