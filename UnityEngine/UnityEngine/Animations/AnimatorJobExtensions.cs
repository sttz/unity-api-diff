using System;
using UnityEngine;

namespace UnityEngine.Animations
{

public static class AnimatorJobExtensions
{
    static public void AddJobDependency(Animator animator, Unity.Jobs.JobHandle jobHandle);
    static public Animations.PropertyStreamHandle BindCustomStreamProperty(Animator animator, string property, Animations.CustomStreamPropertyType type);
    static public Animations.PropertySceneHandle BindSceneProperty(Animator animator, Transform transform, Type type, string property);
    static public Animations.PropertySceneHandle BindSceneProperty(Animator animator, Transform transform, Type type, string property, bool isObjectReference);
    static public Animations.TransformSceneHandle BindSceneTransform(Animator animator, Transform transform);
    static public Animations.PropertyStreamHandle BindStreamProperty(Animator animator, Transform transform, Type type, string property);
    static public Animations.PropertyStreamHandle BindStreamProperty(Animator animator, Transform transform, Type type, string property, bool isObjectReference);
    static public Animations.TransformStreamHandle BindStreamTransform(Animator animator, Transform transform);
    static public void CloseAnimationStream(Animator animator, Animations.AnimationStream stream);
    static public bool OpenAnimationStream(Animator animator, Animations.AnimationStream stream);
    static public void ResolveAllSceneHandles(Animator animator);
    static public void ResolveAllStreamHandles(Animator animator);

}

}
