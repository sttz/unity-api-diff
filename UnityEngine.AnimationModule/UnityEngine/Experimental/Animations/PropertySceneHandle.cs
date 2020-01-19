using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.Animations
{

public struct PropertySceneHandle
{
    public bool GetBool(Experimental.Animations.AnimationStream stream);
    public float GetFloat(Experimental.Animations.AnimationStream stream);
    public int GetInt(Experimental.Animations.AnimationStream stream);
    public bool IsResolved(Experimental.Animations.AnimationStream stream);
    public bool IsValid(Experimental.Animations.AnimationStream stream);
    public void Resolve(Experimental.Animations.AnimationStream stream);
    public void SetBool(Experimental.Animations.AnimationStream stream, bool value);
    public void SetFloat(Experimental.Animations.AnimationStream stream, float value);
    public void SetInt(Experimental.Animations.AnimationStream stream, int value);

}

}
