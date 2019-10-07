using System;
using UnityEngine;

namespace UnityEngine.Experimental.Animations
{

public static class AnimatorJobExtensions
{
    static public Experimental.Animations.PropertySceneHandle BindSceneProperty(Animator animator, Transform transform, Type type, string property);
    static public Experimental.Animations.PropertySceneHandle BindSceneProperty(Animator animator, Transform transform, Type type, string property, bool isObjectReference);
    static public Experimental.Animations.TransformSceneHandle BindSceneTransform(Animator animator, Transform transform);
    static public Experimental.Animations.PropertyStreamHandle BindStreamProperty(Animator animator, Transform transform, Type type, string property);
    static public Experimental.Animations.PropertyStreamHandle BindStreamProperty(Animator animator, Transform transform, Type type, string property, bool isObjectReference);
    static public Experimental.Animations.TransformStreamHandle BindStreamTransform(Animator animator, Transform transform);
    static public void CloseAnimationStream(Animator animator, Experimental.Animations.AnimationStream stream);
    static public bool OpenAnimationStream(Animator animator, Experimental.Animations.AnimationStream stream);
    static public void ResolveAllSceneHandles(Animator animator);
    static public void ResolveAllStreamHandles(Animator animator);

}

}
