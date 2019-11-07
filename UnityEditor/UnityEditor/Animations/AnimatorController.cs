using System;
using UnityEngine;

namespace UnityEditor.Animations
{

public sealed class AnimatorController : RuntimeAnimatorController
{
    static public AnimationClip AllocateAnimatorClip(string name);
    static public UnityEditor.Animations.AnimatorController CreateAnimatorControllerAtPath(string path);
    static public UnityEditor.Animations.AnimatorController CreateAnimatorControllerAtPathWithClip(string path, AnimationClip clip);
    static public int CreateStateMachineBehaviour(UnityEditor.MonoScript script);
    static public UnityEditor.Animations.StateMachineBehaviourContext[] FindStateMachineBehaviourContext(StateMachineBehaviour behaviour);
    static public void SetAnimatorController(Animator animator, UnityEditor.Animations.AnimatorController controller);

    public UnityEditor.Animations.AnimatorControllerLayer[] layers { get; set; }
    public AnimatorControllerParameter[] parameters { get; set; }

    public AnimatorController();

    public StateMachineBehaviour AddEffectiveStateMachineBehaviour(Type stateMachineBehaviourType, UnityEditor.Animations.AnimatorState state, int layerIndex);
    public T AddEffectiveStateMachineBehaviour(UnityEditor.Animations.AnimatorState state, int layerIndex);
    public void AddLayer(string name);
    public void AddLayer(UnityEditor.Animations.AnimatorControllerLayer layer);
    public UnityEditor.Animations.AnimatorState AddMotion(Motion motion);
    public UnityEditor.Animations.AnimatorState AddMotion(Motion motion, int layerIndex);
    public void AddParameter(string name, AnimatorControllerParameterType type);
    public void AddParameter(AnimatorControllerParameter paramater);
    public UnityEditor.Animations.AnimatorState CreateBlendTreeInController(string name, out UnityEditor.Animations.BlendTree tree);
    public UnityEditor.Animations.AnimatorState CreateBlendTreeInController(string name, out UnityEditor.Animations.BlendTree tree, int layerIndex);
    public T[] GetBehaviours();
    public StateMachineBehaviour[] GetStateEffectiveBehaviours(UnityEditor.Animations.AnimatorState state, int layerIndex);
    public Motion GetStateEffectiveMotion(UnityEditor.Animations.AnimatorState state);
    public Motion GetStateEffectiveMotion(UnityEditor.Animations.AnimatorState state, int layerIndex);
    public string MakeUniqueLayerName(string name);
    public string MakeUniqueParameterName(string name);
    public void RemoveLayer(int index);
    public void RemoveParameter(int index);
    public void RemoveParameter(AnimatorControllerParameter parameter);
    public void SetStateEffectiveBehaviours(UnityEditor.Animations.AnimatorState state, int layerIndex, StateMachineBehaviour[] behaviours);
    public void SetStateEffectiveMotion(UnityEditor.Animations.AnimatorState state, Motion motion);
    public void SetStateEffectiveMotion(UnityEditor.Animations.AnimatorState state, Motion motion, int layerIndex);

}

}
