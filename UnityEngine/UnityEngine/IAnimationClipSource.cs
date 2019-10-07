using System;
using UnityEngine;

namespace UnityEngine
{

public interface IAnimationClipSource
{
    public void GetAnimationClips(System.Collections.Generic.List<AnimationClip> results);

}

}
