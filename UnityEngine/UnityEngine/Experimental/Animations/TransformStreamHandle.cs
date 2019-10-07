using System;
using UnityEngine;

namespace UnityEngine.Experimental.Animations
{

public struct TransformStreamHandle
{
    public void GetGlobalTR(Experimental.Animations.AnimationStream stream, out Vector3 position, out Quaternion rotation);
    public Vector3 GetLocalPosition(Experimental.Animations.AnimationStream stream);
    public Quaternion GetLocalRotation(Experimental.Animations.AnimationStream stream);
    public Vector3 GetLocalScale(Experimental.Animations.AnimationStream stream);
    public void GetLocalTRS(Experimental.Animations.AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale);
    public Vector3 GetPosition(Experimental.Animations.AnimationStream stream);
    public bool GetPositionReadMask(Experimental.Animations.AnimationStream stream);
    public Quaternion GetRotation(Experimental.Animations.AnimationStream stream);
    public bool GetRotationReadMask(Experimental.Animations.AnimationStream stream);
    public bool GetScaleReadMask(Experimental.Animations.AnimationStream stream);
    public bool IsResolved(Experimental.Animations.AnimationStream stream);
    public bool IsValid(Experimental.Animations.AnimationStream stream);
    public void Resolve(Experimental.Animations.AnimationStream stream);
    public void SetGlobalTR(Experimental.Animations.AnimationStream stream, Vector3 position, Quaternion rotation, bool useMask);
    public void SetLocalPosition(Experimental.Animations.AnimationStream stream, Vector3 position);
    public void SetLocalRotation(Experimental.Animations.AnimationStream stream, Quaternion rotation);
    public void SetLocalScale(Experimental.Animations.AnimationStream stream, Vector3 scale);
    public void SetLocalTRS(Experimental.Animations.AnimationStream stream, Vector3 position, Quaternion rotation, Vector3 scale, bool useMask);
    public void SetPosition(Experimental.Animations.AnimationStream stream, Vector3 position);
    public void SetRotation(Experimental.Animations.AnimationStream stream, Quaternion rotation);

}

}
