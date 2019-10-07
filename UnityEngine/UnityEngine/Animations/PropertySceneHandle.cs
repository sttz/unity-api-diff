using System;
using UnityEngine;

namespace UnityEngine.Animations
{

public struct PropertySceneHandle
{
    public bool GetBool(Animations.AnimationStream stream);
    public float GetFloat(Animations.AnimationStream stream);
    public int GetInt(Animations.AnimationStream stream);
    public bool IsResolved(Animations.AnimationStream stream);
    public bool IsValid(Animations.AnimationStream stream);
    public void Resolve(Animations.AnimationStream stream);
    public void SetBool(Animations.AnimationStream stream, bool value);
    public void SetFloat(Animations.AnimationStream stream, float value);
    public void SetInt(Animations.AnimationStream stream, int value);

}

}
