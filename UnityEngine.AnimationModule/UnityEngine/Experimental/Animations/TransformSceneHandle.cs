using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.Animations
{

public struct TransformSceneHandle
{
    public Vector3 GetLocalPosition(Experimental.Animations.AnimationStream stream);
    public Quaternion GetLocalRotation(Experimental.Animations.AnimationStream stream);
    public Vector3 GetLocalScale(Experimental.Animations.AnimationStream stream);
    public Vector3 GetPosition(Experimental.Animations.AnimationStream stream);
    public Quaternion GetRotation(Experimental.Animations.AnimationStream stream);
    public bool IsValid(Experimental.Animations.AnimationStream stream);
    public void SetLocalPosition(Experimental.Animations.AnimationStream stream, Vector3 position);
    public void SetLocalRotation(Experimental.Animations.AnimationStream stream, Quaternion rotation);
    public void SetLocalScale(Experimental.Animations.AnimationStream stream, Vector3 scale);
    public void SetPosition(Experimental.Animations.AnimationStream stream, Vector3 position);
    public void SetRotation(Experimental.Animations.AnimationStream stream, Quaternion rotation);

}

}
