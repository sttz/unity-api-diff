using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Animations
{

public struct AnimationLayerMixerPlayable : Playables.IPlayable, IEquatable<Animations.AnimationLayerMixerPlayable>
{
    static public Animations.AnimationLayerMixerPlayable Null { get; }

    static public Animations.AnimationLayerMixerPlayable Create(Playables.PlayableGraph graph, int inputCount = 0);

    public bool Equals(Animations.AnimationLayerMixerPlayable other);
    public Playables.PlayableHandle GetHandle();
    public bool IsLayerAdditive(uint layerIndex);
    public void SetLayerAdditive(uint layerIndex, bool value);
    public void SetLayerMaskFromAvatarMask(uint layerIndex, AvatarMask mask);

}

}
