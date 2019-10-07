using System;
using UnityEngine;

namespace UnityEngine.Experimental.Animations
{

public static class AnimationPlayableOutputExtensions
{
    static public Experimental.Animations.AnimationStreamSource GetAnimationStreamSource(Animations.AnimationPlayableOutput output);
    static public ushort GetSortingOrder(Animations.AnimationPlayableOutput output);
    static public void SetAnimationStreamSource(Animations.AnimationPlayableOutput output, Experimental.Animations.AnimationStreamSource streamSource);
    static public void SetSortingOrder(Animations.AnimationPlayableOutput output, ushort sortingOrder);

}

}
