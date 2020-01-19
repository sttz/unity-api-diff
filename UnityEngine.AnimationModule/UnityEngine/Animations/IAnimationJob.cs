using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Animations
{

public interface IAnimationJob
{
    public void ProcessAnimation(Animations.AnimationStream stream);
    public void ProcessRootMotion(Animations.AnimationStream stream);

}

}
