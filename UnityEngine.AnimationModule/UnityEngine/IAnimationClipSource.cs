using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public interface IAnimationClipSource
{
    public void GetAnimationClips(List<AnimationClip> results);

}

}