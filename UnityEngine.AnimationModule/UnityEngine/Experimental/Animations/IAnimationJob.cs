using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.Animations
{

public interface IAnimationJob
{
    public void ProcessAnimation(Experimental.Animations.AnimationStream stream);
    public void ProcessRootMotion(Experimental.Animations.AnimationStream stream);

}

}
