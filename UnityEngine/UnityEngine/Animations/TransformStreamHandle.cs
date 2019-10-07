using System;
using UnityEngine;

namespace UnityEngine.Animations
{

public struct TransformStreamHandle
{
    public void GetGlobalTR(Animations.AnimationStream stream, out Vector3 position, out Quaternion rotation);
    public Vector3 GetLocalPosition(Animations.AnimationStream stream);
    public Quaternion GetLocalRotation(Animations.AnimationStream stream);
    public Vector3 GetLocalScale(Animations.AnimationStream stream);
    public void GetLocalTRS(Animations.AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale);
    public Vector3 GetPosition(Animations.AnimationStream stream);
    public bool GetPositionReadMask(Animations.AnimationStream stream);
    public Quaternion GetRotation(Animations.AnimationStream stream);
    public bool GetRotationReadMask(Animations.AnimationStream stream);
    public bool GetScaleReadMask(Animations.AnimationStream stream);
    public bool IsResolved(Animations.AnimationStream stream);
    public bool IsValid(Animations.AnimationStream stream);
    public void Resolve(Animations.AnimationStream stream);
    public void SetGlobalTR(Animations.AnimationStream stream, Vector3 position, Quaternion rotation, bool useMask);
    public void SetLocalPosition(Animations.AnimationStream stream, Vector3 position);
    public void SetLocalRotation(Animations.AnimationStream stream, Quaternion rotation);
    public void SetLocalScale(Animations.AnimationStream stream, Vector3 scale);
    public void SetLocalTRS(Animations.AnimationStream stream, Vector3 position, Quaternion rotation, Vector3 scale, bool useMask);
    public void SetPosition(Animations.AnimationStream stream, Vector3 position);
    public void SetRotation(Animations.AnimationStream stream, Quaternion rotation);

}

}
