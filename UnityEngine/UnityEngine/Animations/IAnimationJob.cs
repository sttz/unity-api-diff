using System;
using UnityEngine;

namespace UnityEngine.Animations
{

public interface IAnimationJob
{
    public void ProcessAnimation(Animations.AnimationStream stream);
    public void ProcessRootMotion(Animations.AnimationStream stream);

}

}
